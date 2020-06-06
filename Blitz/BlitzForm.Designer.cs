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
			this.coinBox1 = new System.Windows.Forms.PictureBox();
			this.carBox = new System.Windows.Forms.PictureBox();
			this.coinBox2 = new System.Windows.Forms.PictureBox();
			this.coinBox4 = new System.Windows.Forms.PictureBox();
			this.coinBox3 = new System.Windows.Forms.PictureBox();
			this.coinLabel = new System.Windows.Forms.Label();
			this.enemyPink = new System.Windows.Forms.PictureBox();
			this.enemyWhite = new System.Windows.Forms.PictureBox();
			this.enemyGreen = new System.Windows.Forms.PictureBox();
			this.enemyBlue = new System.Windows.Forms.PictureBox();
			this.gameOverLabel = new System.Windows.Forms.Label();
			this.highscoreLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.coinBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coinBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coinBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coinBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyPink)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyWhite)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyBlue)).BeginInit();
			this.SuspendLayout();
			// 
			// gameTimer
			// 
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
			// 
			// backgroundTimer
			// 
			this.backgroundTimer.Interval = 15;
			this.backgroundTimer.Tick += new System.EventHandler(this.backgroundTimer_Tick);
			// 
			// coinBox1
			// 
			this.coinBox1.BackColor = System.Drawing.Color.Transparent;
			this.coinBox1.BackgroundImage = global::Blitz.Properties.Resources.coin;
			this.coinBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.coinBox1.Location = new System.Drawing.Point(126, 37);
			this.coinBox1.Name = "coinBox1";
			this.coinBox1.Size = new System.Drawing.Size(20, 20);
			this.coinBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.coinBox1.TabIndex = 0;
			this.coinBox1.TabStop = false;
			// 
			// carBox
			// 
			this.carBox.BackColor = System.Drawing.Color.Transparent;
			this.carBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carBox.BackgroundImage")));
			this.carBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.carBox.Location = new System.Drawing.Point(112, 484);
			this.carBox.Name = "carBox";
			this.carBox.Size = new System.Drawing.Size(32, 43);
			this.carBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.carBox.TabIndex = 1;
			this.carBox.TabStop = false;
			// 
			// coinBox2
			// 
			this.coinBox2.BackColor = System.Drawing.Color.Transparent;
			this.coinBox2.BackgroundImage = global::Blitz.Properties.Resources.coin;
			this.coinBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.coinBox2.Location = new System.Drawing.Point(329, 22);
			this.coinBox2.Name = "coinBox2";
			this.coinBox2.Size = new System.Drawing.Size(20, 20);
			this.coinBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.coinBox2.TabIndex = 2;
			this.coinBox2.TabStop = false;
			// 
			// coinBox4
			// 
			this.coinBox4.BackColor = System.Drawing.Color.Transparent;
			this.coinBox4.BackgroundImage = global::Blitz.Properties.Resources.coin;
			this.coinBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.coinBox4.Location = new System.Drawing.Point(268, 84);
			this.coinBox4.Name = "coinBox4";
			this.coinBox4.Size = new System.Drawing.Size(20, 20);
			this.coinBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.coinBox4.TabIndex = 3;
			this.coinBox4.TabStop = false;
			// 
			// coinBox3
			// 
			this.coinBox3.BackColor = System.Drawing.Color.Transparent;
			this.coinBox3.BackgroundImage = global::Blitz.Properties.Resources.coin;
			this.coinBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.coinBox3.Location = new System.Drawing.Point(103, 159);
			this.coinBox3.Name = "coinBox3";
			this.coinBox3.Size = new System.Drawing.Size(20, 20);
			this.coinBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.coinBox3.TabIndex = 4;
			this.coinBox3.TabStop = false;
			// 
			// coinLabel
			// 
			this.coinLabel.AutoSize = true;
			this.coinLabel.BackColor = System.Drawing.Color.Transparent;
			this.coinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.coinLabel.ForeColor = System.Drawing.Color.Black;
			this.coinLabel.Location = new System.Drawing.Point(56, 9);
			this.coinLabel.Name = "coinLabel";
			this.coinLabel.Size = new System.Drawing.Size(67, 17);
			this.coinLabel.TabIndex = 5;
			this.coinLabel.Text = "Coins: 0";
			// 
			// enemyPink
			// 
			this.enemyPink.BackColor = System.Drawing.Color.Transparent;
			this.enemyPink.BackgroundImage = global::Blitz.Properties.Resources.enemyPink;
			this.enemyPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.enemyPink.Location = new System.Drawing.Point(59, 59);
			this.enemyPink.Name = "enemyPink";
			this.enemyPink.Size = new System.Drawing.Size(32, 43);
			this.enemyPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.enemyPink.TabIndex = 6;
			this.enemyPink.TabStop = false;
			// 
			// enemyWhite
			// 
			this.enemyWhite.BackColor = System.Drawing.Color.Transparent;
			this.enemyWhite.BackgroundImage = global::Blitz.Properties.Resources.enemyWhite;
			this.enemyWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.enemyWhite.Location = new System.Drawing.Point(313, 112);
			this.enemyWhite.Name = "enemyWhite";
			this.enemyWhite.Size = new System.Drawing.Size(32, 43);
			this.enemyWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.enemyWhite.TabIndex = 7;
			this.enemyWhite.TabStop = false;
			// 
			// enemyGreen
			// 
			this.enemyGreen.BackColor = System.Drawing.Color.Transparent;
			this.enemyGreen.BackgroundImage = global::Blitz.Properties.Resources.enemyGreen;
			this.enemyGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.enemyGreen.Location = new System.Drawing.Point(252, 11);
			this.enemyGreen.Name = "enemyGreen";
			this.enemyGreen.Size = new System.Drawing.Size(32, 43);
			this.enemyGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.enemyGreen.TabIndex = 8;
			this.enemyGreen.TabStop = false;
			// 
			// enemyBlue
			// 
			this.enemyBlue.BackColor = System.Drawing.Color.Transparent;
			this.enemyBlue.BackgroundImage = global::Blitz.Properties.Resources.enemyBlue;
			this.enemyBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.enemyBlue.Location = new System.Drawing.Point(140, 97);
			this.enemyBlue.Name = "enemyBlue";
			this.enemyBlue.Size = new System.Drawing.Size(32, 43);
			this.enemyBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.enemyBlue.TabIndex = 9;
			this.enemyBlue.TabStop = false;
			// 
			// gameOverLabel
			// 
			this.gameOverLabel.AutoSize = true;
			this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
			this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gameOverLabel.ForeColor = System.Drawing.Color.Crimson;
			this.gameOverLabel.Location = new System.Drawing.Point(73, 207);
			this.gameOverLabel.Name = "gameOverLabel";
			this.gameOverLabel.Size = new System.Drawing.Size(291, 51);
			this.gameOverLabel.TabIndex = 10;
			this.gameOverLabel.Text = "GAME OVER";
			this.gameOverLabel.Visible = false;
			// 
			// highscoreLabel
			// 
			this.highscoreLabel.AutoSize = true;
			this.highscoreLabel.BackColor = System.Drawing.Color.Transparent;
			this.highscoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highscoreLabel.Location = new System.Drawing.Point(106, 269);
			this.highscoreLabel.Name = "highscoreLabel";
			this.highscoreLabel.Size = new System.Drawing.Size(152, 31);
			this.highscoreLabel.TabIndex = 11;
			this.highscoreLabel.Text = "Highscore: ";
			this.highscoreLabel.Visible = false;
			// 
			// BlitzForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(436, 571);
			this.Controls.Add(this.highscoreLabel);
			this.Controls.Add(this.coinLabel);
			this.Controls.Add(this.carBox);
			this.Controls.Add(this.gameOverLabel);
			this.Controls.Add(this.coinBox2);
			this.Controls.Add(this.coinBox4);
			this.Controls.Add(this.coinBox3);
			this.Controls.Add(this.coinBox1);
			this.Controls.Add(this.enemyGreen);
			this.Controls.Add(this.enemyPink);
			this.Controls.Add(this.enemyBlue);
			this.Controls.Add(this.enemyWhite);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.Name = "BlitzForm";
			this.Text = "Blitz";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlitzForm_KeyDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BlitzForm_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.coinBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coinBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coinBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coinBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyPink)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyWhite)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemyBlue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Timer backgroundTimer;
		private System.Windows.Forms.PictureBox coinBox1;
		private System.Windows.Forms.PictureBox carBox;
		private System.Windows.Forms.PictureBox coinBox2;
		private System.Windows.Forms.PictureBox coinBox4;
		private System.Windows.Forms.PictureBox coinBox3;
		private System.Windows.Forms.Label coinLabel;
		private System.Windows.Forms.PictureBox enemyPink;
		private System.Windows.Forms.PictureBox enemyWhite;
		private System.Windows.Forms.PictureBox enemyGreen;
		private System.Windows.Forms.PictureBox enemyBlue;
		private System.Windows.Forms.Label gameOverLabel;
		private System.Windows.Forms.Label highscoreLabel;
	}
}

