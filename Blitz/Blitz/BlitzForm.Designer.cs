namespace Blitz {
	partial class BlitzForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlitzForm));
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.backgroundTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 65;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
			// 
			// backgroundTimer
			// 
			this.backgroundTimer.Interval = 65;
			this.backgroundTimer.Tick += new System.EventHandler(this.backgroundTimer_Tick);
			// 
			// BlitzForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(582, 703);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "BlitzForm";
			this.Text = "Blitz";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Timer backgroundTimer;
	}
}

