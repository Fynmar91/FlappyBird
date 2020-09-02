using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
	public partial class Form1 : Form
	{
		const int GRAVITY = 16;

		Random random = new Random();

		double pipeSpeed = 10;
		double gravity = GRAVITY;
		int score = 0;
		bool goingUp = false;
		bool reset = false;

		public Form1()
		{
			InitializeComponent();
		}

		private void gameTimerEvent(object sender, EventArgs e)
		{
			// Grafiken bewegen
			flappyBird.Top += (int)gravity;
			pipeBottom.Left -= (int)pipeSpeed;
			pipeTop.Left -= (int)pipeSpeed;

			// Röhrengeschwinidkeit erhöhen
			pipeSpeed *= 1.001;

			// Beschleunigung bei Richtungswechsel
			if (gravity < 0 && gravity > -GRAVITY)
			{
				gravity *= 1.12;
				if (gravity <= -GRAVITY) gravity = -GRAVITY;
			}
			else if (gravity > 0 && gravity < GRAVITY)
			{
				gravity *= 1.12;
				if (gravity >= GRAVITY) gravity = GRAVITY;
			}

			// Röhren zurücksetzen
			if (pipeBottom.Left < -120 && pipeTop.Left < -120)
			{
				pipeBottom.Left = 600 + random.Next(200);
				pipeTop.Left = 600 + random.Next(200);
				reset = true;
			}

			// Röhrenhöhe verändern
			if (reset == true && pipeBottom.Left > 600 && pipeTop.Left > 600) 
			{
				int offset = random.Next(-120, 120);
				pipeTop.Top = -200 + offset;
				pipeBottom.Top = 420 + offset;
				reset = false;
			}

			// Beschriftungen updaten
			pipeSpeedLabel.Text = ((int)pipeSpeed).ToString();
			gravityLabel.Text = gravity.ToString("0.##");
		}

		private void gameKeyIsDown(object sender, KeyEventArgs e)
		{
			if (goingUp == false && e.KeyCode == Keys.Space)
			{
				gravity = -GRAVITY / 4;
				goingUp = true;
			}
		}
		
		private void gameKeyIsUp(object sender, KeyEventArgs e)
		{
			if (goingUp == true && e.KeyCode == Keys.Space)
			{
				gravity = GRAVITY / 4;
				goingUp = false;
			}
		}
	}
}
