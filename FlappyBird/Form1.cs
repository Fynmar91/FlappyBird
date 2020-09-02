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

		int pipeSpeed = 10;
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
			pipeBottom.Left -= pipeSpeed;
			pipeTop.Left -= pipeSpeed;
			flappyBirdCollider.Top = flappyBird.Top + 15;
			flappyBirdCollider.Left = flappyBird.Left + 20;

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
				score++;
				pipeSpeed++;
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

			// Flappy Bird im Fenster halten
			if (flappyBird.Top < 0) flappyBird.Top = 0;

			// Beschriftungen updaten
			pipeSpeedLabel.Text = pipeSpeed.ToString();
			gravityLabel.Text = gravity.ToString("0.##");
			scoreLabel.Text = "Score: " + score.ToString();

			// Prüfe ob verloren
			if (flappyBirdCollider.Bounds.IntersectsWith(pipeBottom.Bounds) ||
				flappyBirdCollider.Bounds.IntersectsWith(pipeTop.Bounds) ||
				flappyBirdCollider.Bounds.IntersectsWith(ground.Bounds))
			{
				endGame();
			}
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

		private void endGame()
		{
			gameTImer.Stop();
			scoreLabel.Text += " Game over!";
		}
	}
}
