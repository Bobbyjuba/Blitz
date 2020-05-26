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
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road0.png"),
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road1.png"),
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road2.png"),
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road3.png"),
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road4.png"),
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road5.png"),
			new Bitmap(@"C:\Users\Bobby\Source\Repos\Bobbyjuba\Blitz\Blitz\Blitz\assets\road6.png")
		};

		private int index = 0;

		private Random rand = new Random();
		public BlitzForm() {
			InitializeComponent();
			backgroundTimer.Start();
		}

		private void gameTimer_Tick(object sender, EventArgs e) {

		}

		private void backgroundTimer_Tick(object sender, EventArgs e) {
			displayBackground();
		}

		private void displayBackground() {
			if (index == 7)
				index = 0;

			this.BackgroundImage = background[index];
			index++;
		}
	}
}