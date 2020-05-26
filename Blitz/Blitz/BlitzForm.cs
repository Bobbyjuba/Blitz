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

		public BlitzForm() {
			InitializeComponent();
			backgroundTimer.Start();
		}

		// gameTimer should handle the majority of event logic
		private void gameTimer_Tick(object sender, EventArgs e) {
			if (coinBox.Bounds.IntersectsWith(carBox.Bounds)) {
				coinBox.Visible = false;
				coins++;
			}

			if (coinBox.Location.Y > carBox.Bottom + 5) {
				coinBox.Visible = false;
			}

			coinBox.Top += 17;
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

		private void BlitzForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.A) {
				if ((carBox.Location.X - (carBox.Width / 2)) >= 53)
					carBox.Left = carBox.Left - (carBox.Width / 2);

				else if (carBox.Location.X - (carBox.Width / 2) < 53)
					carBox.Left = carBox.Left - (carBox.Left - 53);
			}

			if (e.KeyCode == Keys.D) {
				if (carBox.Left + (carBox.Width / 2) <= 350)
					carBox.Left = carBox.Left + (carBox.Width / 2);

				else if (carBox.Left + (carBox.Width / 2) > 350)
					carBox.Left = carBox.Left + (carBox.Width) + (350 - carBox.Right);
			}
		}

		private void BlitzForm_MouseMove(object sender, MouseEventArgs e) {
			if (e.X >= (53 + (carBox.Width / 2)) && e.X <= (350 + (carBox.Width / 2))) {
				carBox.Left = e.X - (carBox.Width / 2);
			}
		}
	}
}