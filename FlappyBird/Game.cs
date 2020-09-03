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
	public partial class Game : Form
	{
		const int GRAVITY = 12;

		Random random;
		int pipeSpeed;
		double gravity;
		int score;
		bool goingUp;
		bool reset;

		public Game()
		{
			InitializeComponent();
			SetupGame();
		}

		private void SetupGame()
		{
			// Spielzustand herstellen
			random = new Random();
			pipeSpeed = 10;
			gravity = GRAVITY;
			score = 0;
			goingUp = false;
			reset = false;
			flappyBird.Top = 200;
			flappyBird.Left = 100;
			pipeBottom.Left = 600 + random.Next(200);
			pipeTop.Left = 600 + random.Next(200);
			ground.Left = 0;
			ground.Top = 675;
			ground2.Left = 600;
			ground2.Top = 675;
		}

		private void gameTimerEvent(object sender, EventArgs e)
		{
			// Grafiken bewegen
			flappyBird.Top += (int)gravity;
			pipeBottom.Left -= pipeSpeed;
			pipeTop.Left -= pipeSpeed;
			ground.Left -= pipeSpeed;
			ground2.Left -= pipeSpeed;

			// FlappyBird Kolliosionsbox verschieben
			flappyBirdCollider.Top = flappyBird.Top + 15;
			flappyBirdCollider.Left = flappyBird.Left + 20;

			// Beschleunigung bei Richtungswechsel
			if (gravity < 0 && gravity > -GRAVITY)
			{
				gravity *= 1.2;
				if (gravity <= -GRAVITY) gravity = -GRAVITY;
			}
			else if (gravity > 0 && gravity < GRAVITY)
			{
				gravity *= 1.2;
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

			// Boden zurücksetzen
			if (ground.Left < -600) ground.Left = 600;
			if (ground2.Left < -600) ground2.Left = 600;

			// FlappyBird im Fenster halten
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
				gravity = -GRAVITY / 3;
				goingUp = true;
			}
			else if (e.KeyCode == Keys.R)
			{
				// Neustarten
				SetupGame();
				gameTimer.Start();
			}
		}
		
		private void gameKeyIsUp(object sender, KeyEventArgs e)
		{
			if (goingUp == true && e.KeyCode == Keys.Space)
			{
				gravity = GRAVITY / 3;
				goingUp = false;
			}
		}

		private void endGame()
		{
			// Spiel beenden
			gameTimer.Stop();
			scoreLabel.Text += "   GAME OVER   restart with R";
		}

		private void highscoreButton_Click(object sender, EventArgs e)
		{
			Form highscores = new Highscores();
			highscores.Show();
		}
	}
}
