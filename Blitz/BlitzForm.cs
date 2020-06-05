using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
		private int coins = 0;
		private Random r = new Random();
		private readonly int moveSpeed = 9;
		private readonly int roadLeftSide = 52;
		private readonly int roadRightSide = 348;
		private readonly int initialYSpawn = 5;

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

		// Check if the player has collected any of the coins or if the coins have moved past the player
		private void coinCheck() {
			if (coinBox1.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox1.Location = new Point(x, initialYSpawn);
				coins++;
				updateScore();
			}

			if (coinBox1.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox1.Location = new Point(x, initialYSpawn);
			}

			if (coinBox2.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox2.Location = new Point(x, initialYSpawn);
				coins++;
				updateScore();
			}

			if (coinBox2.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox2.Location = new Point(x, initialYSpawn);
			}

			if (coinBox3.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox3.Location = new Point(x, initialYSpawn);
				coins++;
				updateScore();
			}

			if (coinBox3.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox3.Location = new Point(x, initialYSpawn);
			}

			if (coinBox4.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox4.Location = new Point(x, initialYSpawn);
				coins++;
				updateScore();
			}

			if (coinBox4.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				coinBox4.Location = new Point(x, initialYSpawn);
			}
		}

		// Check if the player has crashed into any of the enemy cars or the enemy cars have moved past the player
		private void enemyCheck() {
			if (enemyBlue.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyBlue.Location = new Point(x, initialYSpawn);
				backgroundTimer.Stop();
				gameTimer.Stop();
				gameOverLabel.Visible = true;
			}

			if (enemyBlue.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyBlue.Location = new Point(x, initialYSpawn);
			}

			if (enemyGreen.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyGreen.Location = new Point(x, initialYSpawn);
				backgroundTimer.Stop();
				gameTimer.Stop();
				gameOverLabel.Visible = true;
			}

			if (enemyGreen.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyGreen.Location = new Point(x, initialYSpawn);
			}

			if (enemyPink.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyPink.Location = new Point(x, initialYSpawn);
				backgroundTimer.Stop();
				gameTimer.Stop();
				gameOverLabel.Visible = true;
			}

			if (enemyPink.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyPink.Location = new Point(x, initialYSpawn);
			}

			if (enemyWhite.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyWhite.Location = new Point(x, initialYSpawn);
				backgroundTimer.Stop();
				gameTimer.Stop();
				gameOverLabel.Visible = true;
			}

			if (enemyWhite.Location.Y > carBox.Bottom + initialYSpawn) {
				int x = r.Next(roadLeftSide, roadRightSide);
				enemyWhite.Location = new Point(x, initialYSpawn);
			}
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
		}

		// Mouse-based movement (the superior style!)
		private void BlitzForm_MouseMove(object sender, MouseEventArgs e) {
			if (e.X >= (roadLeftSide + (carBox.Width / 2)) && e.X <= (roadRightSide + (carBox.Width / 2))) {
				carBox.Left = e.X - (carBox.Width / 2);
			}
		}
	}
}