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
			this.coinBox = new System.Windows.Forms.PictureBox();
			this.carBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.coinBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carBox)).BeginInit();
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
			// coinBox
			// 
			this.coinBox.BackColor = System.Drawing.Color.Transparent;
			this.coinBox.BackgroundImage = global::Blitz.Properties.Resources.coin;
			this.coinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.coinBox.Location = new System.Drawing.Point(112, 45);
			this.coinBox.Name = "coinBox";
			this.coinBox.Size = new System.Drawing.Size(26, 22);
			this.coinBox.TabIndex = 0;
			this.coinBox.TabStop = false;
			// 
			// carBox
			// 
			this.carBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carBox.Location = new System.Drawing.Point(150, 485);
			this.carBox.Name = "carBox";
			this.carBox.Size = new System.Drawing.Size(28, 45);
			this.carBox.TabIndex = 1;
			this.carBox.TabStop = false;
			// 
			// BlitzForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(436, 571);
			this.Controls.Add(this.carBox);
			this.Controls.Add(this.coinBox);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "BlitzForm";
			this.Text = "Blitz";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlitzForm_KeyDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlitzForm_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.coinBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Timer backgroundTimer;
		private System.Windows.Forms.PictureBox coinBox;
		private System.Windows.Forms.PictureBox carBox;
	}
}

