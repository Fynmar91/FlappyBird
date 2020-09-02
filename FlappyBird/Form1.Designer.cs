namespace FlappyBird
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flappyBird = new System.Windows.Forms.PictureBox();
			this.pipeTop = new System.Windows.Forms.PictureBox();
			this.pipeBottom = new System.Windows.Forms.PictureBox();
			this.ground = new System.Windows.Forms.PictureBox();
			this.scoreText = new System.Windows.Forms.Label();
			this.gameTImer = new System.Windows.Forms.Timer(this.components);
			this.gravityLabel = new System.Windows.Forms.Label();
			this.pipeSpeedLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
			this.SuspendLayout();
			// 
			// flappyBird
			// 
			this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
			this.flappyBird.Location = new System.Drawing.Point(113, 163);
			this.flappyBird.Name = "flappyBird";
			this.flappyBird.Size = new System.Drawing.Size(80, 60);
			this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappyBird.TabIndex = 0;
			this.flappyBird.TabStop = false;
			// 
			// pipeTop
			// 
			this.pipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
			this.pipeTop.Location = new System.Drawing.Point(452, -200);
			this.pipeTop.Name = "pipeTop";
			this.pipeTop.Size = new System.Drawing.Size(120, 500);
			this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeTop.TabIndex = 2;
			this.pipeTop.TabStop = false;
			// 
			// pipeBottom
			// 
			this.pipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
			this.pipeBottom.Location = new System.Drawing.Point(370, 420);
			this.pipeBottom.Name = "pipeBottom";
			this.pipeBottom.Size = new System.Drawing.Size(120, 500);
			this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pipeBottom.TabIndex = 3;
			this.pipeBottom.TabStop = false;
			// 
			// ground
			// 
			this.ground.Image = global::FlappyBird.Properties.Resources.ground;
			this.ground.Location = new System.Drawing.Point(-7, 674);
			this.ground.Name = "ground";
			this.ground.Size = new System.Drawing.Size(599, 93);
			this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ground.TabIndex = 4;
			this.ground.TabStop = false;
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.Font = new System.Drawing.Font("Source Sans Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreText.Location = new System.Drawing.Point(12, 9);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(193, 60);
			this.scoreText.TabIndex = 5;
			this.scoreText.Text = "Score: 0";
			// 
			// gameTImer
			// 
			this.gameTImer.Enabled = true;
			this.gameTImer.Interval = 20;
			this.gameTImer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// gravityLabel
			// 
			this.gravityLabel.AutoSize = true;
			this.gravityLabel.BackColor = System.Drawing.Color.White;
			this.gravityLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gravityLabel.Location = new System.Drawing.Point(22, 715);
			this.gravityLabel.Name = "gravityLabel";
			this.gravityLabel.Size = new System.Drawing.Size(15, 16);
			this.gravityLabel.TabIndex = 6;
			this.gravityLabel.Text = "0";
			// 
			// pipeSpeedLabel
			// 
			this.pipeSpeedLabel.AutoSize = true;
			this.pipeSpeedLabel.BackColor = System.Drawing.Color.White;
			this.pipeSpeedLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pipeSpeedLabel.Location = new System.Drawing.Point(122, 715);
			this.pipeSpeedLabel.Name = "pipeSpeedLabel";
			this.pipeSpeedLabel.Size = new System.Drawing.Size(15, 16);
			this.pipeSpeedLabel.TabIndex = 7;
			this.pipeSpeedLabel.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(22, 699);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Gravity";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(122, 699);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Game Speed";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(584, 761);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pipeSpeedLabel);
			this.Controls.Add(this.gravityLabel);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.ground);
			this.Controls.Add(this.pipeBottom);
			this.Controls.Add(this.pipeTop);
			this.Controls.Add(this.flappyBird);
			this.Name = "Form1";
			this.Text = "Flappy Bird";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox flappyBird;
		private System.Windows.Forms.PictureBox pipeTop;
		private System.Windows.Forms.PictureBox pipeBottom;
		private System.Windows.Forms.PictureBox ground;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.Timer gameTImer;
		private System.Windows.Forms.Label gravityLabel;
		private System.Windows.Forms.Label pipeSpeedLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

