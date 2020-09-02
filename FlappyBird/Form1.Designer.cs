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
			this.scoreLabel = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.gravityLabel = new System.Windows.Forms.Label();
			this.pipeSpeedLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.flappyBirdCollider = new System.Windows.Forms.PictureBox();
			this.ground2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flappyBirdCollider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
			this.SuspendLayout();
			// 
			// flappyBird
			// 
			this.flappyBird.BackColor = System.Drawing.Color.Transparent;
			this.flappyBird.Image = global::FlappyBird.Properties.Resources.bird;
			this.flappyBird.Location = new System.Drawing.Point(100, 200);
			this.flappyBird.Name = "flappyBird";
			this.flappyBird.Size = new System.Drawing.Size(80, 60);
			this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappyBird.TabIndex = 0;
			this.flappyBird.TabStop = false;
			// 
			// pipeTop
			// 
			this.pipeTop.BackColor = System.Drawing.Color.Transparent;
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
			this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
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
			this.ground.BackColor = System.Drawing.Color.Transparent;
			this.ground.Image = global::FlappyBird.Properties.Resources.ground;
			this.ground.Location = new System.Drawing.Point(0, 675);
			this.ground.Name = "ground";
			this.ground.Size = new System.Drawing.Size(700, 100);
			this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ground.TabIndex = 4;
			this.ground.TabStop = false;
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.scoreLabel.Font = new System.Drawing.Font("Source Sans Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLabel.ForeColor = System.Drawing.Color.Black;
			this.scoreLabel.Location = new System.Drawing.Point(12, 703);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(97, 31);
			this.scoreLabel.TabIndex = 5;
			this.scoreLabel.Text = "Score: 0";
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// gravityLabel
			// 
			this.gravityLabel.AutoSize = true;
			this.gravityLabel.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.gravityLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gravityLabel.ForeColor = System.Drawing.Color.Black;
			this.gravityLabel.Location = new System.Drawing.Point(512, 744);
			this.gravityLabel.Name = "gravityLabel";
			this.gravityLabel.Size = new System.Drawing.Size(15, 16);
			this.gravityLabel.TabIndex = 6;
			this.gravityLabel.Text = "0";
			// 
			// pipeSpeedLabel
			// 
			this.pipeSpeedLabel.AutoSize = true;
			this.pipeSpeedLabel.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.pipeSpeedLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pipeSpeedLabel.ForeColor = System.Drawing.Color.Black;
			this.pipeSpeedLabel.Location = new System.Drawing.Point(512, 712);
			this.pipeSpeedLabel.Name = "pipeSpeedLabel";
			this.pipeSpeedLabel.Size = new System.Drawing.Size(15, 16);
			this.pipeSpeedLabel.TabIndex = 7;
			this.pipeSpeedLabel.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(512, 728);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Gravity";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(512, 696);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Game Speed";
			// 
			// flappyBirdCollider
			// 
			this.flappyBirdCollider.BackColor = System.Drawing.Color.Transparent;
			this.flappyBirdCollider.Image = global::FlappyBird.Properties.Resources.bird;
			this.flappyBirdCollider.Location = new System.Drawing.Point(179, 271);
			this.flappyBirdCollider.Name = "flappyBirdCollider";
			this.flappyBirdCollider.Size = new System.Drawing.Size(40, 30);
			this.flappyBirdCollider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappyBirdCollider.TabIndex = 10;
			this.flappyBirdCollider.TabStop = false;
			// 
			// ground2
			// 
			this.ground2.BackColor = System.Drawing.Color.Transparent;
			this.ground2.Image = global::FlappyBird.Properties.Resources.ground;
			this.ground2.Location = new System.Drawing.Point(496, 552);
			this.ground2.Name = "ground2";
			this.ground2.Size = new System.Drawing.Size(700, 100);
			this.ground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ground2.TabIndex = 11;
			this.ground2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(584, 761);
			this.Controls.Add(this.flappyBird);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pipeSpeedLabel);
			this.Controls.Add(this.gravityLabel);
			this.Controls.Add(this.pipeTop);
			this.Controls.Add(this.flappyBirdCollider);
			this.Controls.Add(this.ground2);
			this.Controls.Add(this.ground);
			this.Controls.Add(this.pipeBottom);
			this.Name = "Form1";
			this.Text = " ";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flappyBirdCollider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox flappyBird;
		private System.Windows.Forms.PictureBox pipeTop;
		private System.Windows.Forms.PictureBox pipeBottom;
		private System.Windows.Forms.PictureBox ground;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label gravityLabel;
		private System.Windows.Forms.Label pipeSpeedLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox flappyBirdCollider;
		private System.Windows.Forms.PictureBox ground2;
	}
}

