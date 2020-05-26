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

		// Indexer to iterate through background[]
		private int index = 0;
		private int coins = 0;
		private Random r = new Random();
		private int moveSpeed = 11;

		public BlitzForm() {
			InitializeComponent();
			backgroundTimer.Start();
			gameTimer.Start();
		}

		// gameTimer should handle the majority of event logic
		private void gameTimer_Tick(object sender, EventArgs e) {
			coinCheck();
			moveCoins();
		}

		// Check if coins have been touched by the car or if they are now unreachable
		// Reset if either are true
		private void coinCheck() {
			if (coinBox1.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(54, 349);
				coinBox1.Location = new Point(x, 5);
				coins++;
				updateScore();
			}

			if (coinBox1.Location.Y > carBox.Bottom + 5) {
				int x = r.Next(54, 349);
				coinBox1.Location = new Point(x, 5);
			}

			if (coinBox2.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(54, 349);
				coinBox2.Location = new Point(x, 5);
				coins++;
				updateScore();
			}

			if (coinBox2.Location.Y > carBox.Bottom + 5) {
				int x = r.Next(54, 349);
				coinBox2.Location = new Point(x, 5);
			}

			if (coinBox3.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(54, 349);
				coinBox3.Location = new Point(x, 5);
				coins++;
				updateScore();
			}

			if (coinBox3.Location.Y > carBox.Bottom + 5) {
				int x = r.Next(54, 349);
				coinBox3.Location = new Point(x, 5);
			}

			if (coinBox4.Bounds.IntersectsWith(carBox.Bounds)) {
				int x = r.Next(54, 349);
				coinBox4.Location = new Point(x, 5);
				coins++;
				updateScore();
			}

			if (coinBox4.Location.Y > carBox.Bottom + 5) {
				int x = r.Next(54, 349);
				coinBox4.Location = new Point(x, 5);
			}
		}

		private void moveCoins() {
			coinBox1.Top += moveSpeed;
			coinBox2.Top += moveSpeed;
			coinBox3.Top += moveSpeed;
			coinBox4.Top += moveSpeed;
		}

		private void updateScore() {
			coinLabel.Text = $"Coins: {coins}";
		}

		// backgroundTimer should handle the task of displaying the 7 images every 65ms 
		private void backgroundTimer_Tick(object sender, EventArgs e) {
			displayBackground();
		}

		// Increment index every time backgroundTimer ticks, so the next image in the order will display
		private void displayBackground() {
			// Reset when index reaches 7, to stay within bounds of background[]
			if (index == 7)
				index = 0;

			this.BackgroundImage = background[index];
			index++;
		}

		// Key-base movement
		private void BlitzForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.A) {
				if ((carBox.Location.X - (carBox.Width / 2)) >= 48)
					carBox.Left = carBox.Left - (carBox.Width / 2);

				else if (carBox.Location.X - (carBox.Width / 2) < 48)
					carBox.Left = carBox.Left - (carBox.Left - 48);
			}

			if (e.KeyCode == Keys.D) {
				if (carBox.Left + (carBox.Width / 2) <= 342)
					carBox.Left = carBox.Left + (carBox.Width / 2);

				else if (carBox.Left + (carBox.Width / 2) > 342)
					carBox.Left = carBox.Left + (carBox.Width) + (342 - carBox.Right);
			}
		}

		// Mouse-based movement (CHEATING! ;)
		private void BlitzForm_MouseMove(object sender, MouseEventArgs e) {
			if (e.X >= (48 + (carBox.Width / 2)) && e.X <= (342 + (carBox.Width / 2))) {
				carBox.Left = e.X - (carBox.Width / 2);
			}
		}
	}
}