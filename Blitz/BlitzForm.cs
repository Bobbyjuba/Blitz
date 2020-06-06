using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blitz {
	public partial class BlitzForm : Form {

		// Store all of the background images into one Bitmap array
		private Bitmap[] background = new Bitmap[] {
			Properties.Resources.road0,
			Properties.Resources.road1,
			Properties.Resources.road2,
			Properties.Resources.road3,
			Properties.Resources.road4,
			Properties.Resources.road5,
			Properties.Resources.road6
		};

		private int index = 0;
		private Random r = new Random();
		private readonly int moveSpeed = 9;
		private readonly int roadLeftSide = 52;
		private readonly int roadRightSide = 348;
		private const int initialYSpawn = 5;
		private string highscore;
		private string scoreDirectory = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + @"\assets\scores\highscore.txt";
		private List<PictureBox> allCoins { get { return new List<PictureBox> { coinBox1, coinBox2, coinBox3, coinBox4 }; } }
		private List<PictureBox> allEnemies { get { return new List<PictureBox> { enemyBlue, enemyGreen, enemyPink, enemyWhite }; } }
		private int _coins;
		private int coins {
			get { return _coins; }
			set { _coins = value; updateScore(); }
		}


		public BlitzForm() {
			InitializeComponent();
			backgroundTimer.Start();
			gameTimer.Start();
		}

		// gameTimer should handle the majority of event logic
		private void gameTimer_Tick(object sender, EventArgs e) {
			coinCheck();
			moveCoins();
			enemyCheck();
			moveEnemies();
		}

		// respawns a coin or enemy to a random x value and the given y value (initialYSpawn by default)
		private void respawn(PictureBox coin, int yValue = initialYSpawn) {
			int x = r.Next(roadLeftSide, roadRightSide);
			coin.Location = new Point(x, yValue);
		}

		// Check if the player has collected any of the coins or if the coins have moved past the player
		private void coinCheck() {

			allCoins.ForEach(coin => {

				if (coin.Bounds.IntersectsWith(carBox.Bounds)) {
					respawn(coin);
					coins++;
				}

				if (coin.Location.Y > carBox.Bottom + initialYSpawn) {
					respawn(coin);
				}

			});

		}

		// On game over, stop timers and show gameover screen
		private void gameOver(PictureBox enemy) {
			respawn(enemy);
			backgroundTimer.Stop();
			gameTimer.Stop();
			gameOverLabel.Visible = true;
			displayHighscore();
		}

		// Check if the player has crashed into any of the enemy cars or the enemy cars have moved past the player
		private void enemyCheck() {

			allEnemies.ForEach(enemy => {

				if (enemy.Bounds.IntersectsWith(carBox.Bounds)) {
					gameOver(enemy);
				}

				if (enemy.Location.Y > carBox.Bottom + initialYSpawn) {
					respawn(enemy);
				}

			});

		}

		// Move the enemies toward the bottom of the screen
		private void moveEnemies() {
			enemyBlue.Top += moveSpeed;
			enemyGreen.Top += moveSpeed;
			enemyPink.Top += moveSpeed;
			enemyWhite.Top += moveSpeed;
		}

		// Move the coins toward the bottom of the screen
		private void moveCoins() {
			coinBox1.Top += moveSpeed;
			coinBox2.Top += moveSpeed;
			coinBox3.Top += moveSpeed;
			coinBox4.Top += moveSpeed;
		}

		private void displayHighscore() {
			if (System.IO.File.Exists(scoreDirectory)) {
				highscore = System.IO.File.ReadAllText(scoreDirectory);
				if (Convert.ToInt32(highscore) < coins) {
					System.IO.File.WriteAllText(scoreDirectory, Convert.ToString(coins));
					highscore = System.IO.File.ReadAllText(scoreDirectory);
					highscoreLabel.Text = $"Highscore: {highscore}";
					highscoreLabel.Visible = true;
					return;
				}

				highscoreLabel.Text = $"Highscore: {highscore}";
				highscoreLabel.Visible = true;
				return;
			}

			else {
				System.IO.File.WriteAllText(scoreDirectory, Convert.ToString(coins));
				highscore = System.IO.File.ReadAllText(scoreDirectory);
				highscoreLabel.Text = $"Highscore: {highscore}";
				highscoreLabel.Visible = true;
				return;
			}
		}

		// Keep track of how many coins the player has collected
		private void updateScore() {
			coinLabel.Text = $"Coins: {coins}";
		}

		// backgroundTimer should handle the task of displaying the 7 images every 65ms 
		private void backgroundTimer_Tick(object sender, EventArgs e) {
			displayBackground();
		}

		// Increment index every time backgroundTimer ticks, so the next image in the order will display
		private void displayBackground() {
			// Reset when index reaches the end of the array, to stay within bounds of background[]
			if (index == background.Length)
				index = 0;

			this.BackgroundImage = background[index];
			index++;
		}

		// Keyboard-based movement
		private void BlitzForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.A) {
				if ((carBox.Location.X - (carBox.Width / 2)) >= roadLeftSide)
					carBox.Left = carBox.Left - (carBox.Width / 2);

				else if (carBox.Location.X - (carBox.Width / 2) < roadLeftSide)
					carBox.Left = carBox.Left - (carBox.Left - roadLeftSide);
			}

			if (e.KeyCode == Keys.D) {
				if (carBox.Left + (carBox.Width / 2) <= roadRightSide)
					carBox.Left = carBox.Left + (carBox.Width / 2);

				else if (carBox.Left + (carBox.Width / 2) > roadRightSide)
					carBox.Left = carBox.Left + (carBox.Width) + (roadRightSide - carBox.Right);
			}

			if (e.KeyCode == Keys.R && highscoreLabel.Visible) {
				coins = 0;
				gameOverLabel.Visible = false;
				highscoreLabel.Visible = false;
				allEnemies.ForEach(enemy => respawn(enemy, r.Next(initialYSpawn, 20 * initialYSpawn)));
				backgroundTimer.Start();
				gameTimer.Start();
			}
		}

		// Mouse-based movement (the superior style!)
		private void BlitzForm_MouseMove(object sender, MouseEventArgs e) {
			if (e.X >= (roadLeftSide + (carBox.Width / 2)) && e.X <= (roadRightSide + (carBox.Width / 2))) {
				carBox.Left = e.X - (carBox.Width / 2);
			}
		}
	}
}
