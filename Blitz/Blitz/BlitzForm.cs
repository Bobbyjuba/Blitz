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
		public Bitmap[] background = new Bitmap[] {
			Properties.Resources.road0,
			Properties.Resources.road1,
			Properties.Resources.road2,
			Properties.Resources.road3,
			Properties.Resources.road4,
			Properties.Resources.road5,
			Properties.Resources.road6
		};

		private int index = 0;

		public BlitzForm() {
			InitializeComponent();
			backgroundTimer.Start();
		}

		// gameTimer should handle the majority of event logic
		private void gameTimer_Tick(object sender, EventArgs e) {

		}

		// backgroundTimer should handle the task of displaying the 7 images every 65ms 
		private void backgroundTimer_Tick(object sender, EventArgs e) {
			displayBackground();
		}

		// Increment index every time backgroundTimer ticks, so the next image in the order will display
		private void displayBackground() {
			if (index == 7)
				index = 0;

			this.BackgroundImage = background[index];
			index++;
		}
	}
}