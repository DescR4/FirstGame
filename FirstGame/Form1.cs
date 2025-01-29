using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FirstGame
{
	public partial class Form1 : Form
	{
		private const string ResultsFilePath = "results.txt";
		private Point pos;
		private bool dragging, lose = false;
		private int countCoins = 0;
		private Random rand = new Random();
		private int baseSpeed = 5;
		private int baseCoinValue = 1; 
		private int elapsedTime = 0; 


		public Form1()
		{
			InitializeComponent();
			InitializeEvents();
			ResetGame();
		}

		private void InitializeEvents()
		{
			KeyPreview = true;
			KeyPress += Form1_KeyPress;
			KeyDown += Form1_KeyDown;
			btnRestart.Click += btnRestart_Click;
		}

		private void ResetGame()
		{
			enemy1.Top = -160;
			enemy2.Top = -400;
			countCoins = 0;
			lose = false;
			labelLose.Visible = false;
			btnRestart.Visible = false;
			btn_StartMenu.Visible = false;
			labelCoins.Text = "Очки: 0";
			coin1.Top = -500;
			timer.Enabled = true;
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Escape)
				Application.Exit();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (lose) return;

			int speed = 10;
			if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 150)
				player.Left -= speed;
			else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
				player.Left += speed;
		}

		private void btnRestart_Click(object sender, EventArgs e)
		{
			ResetGame();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			int speed = baseSpeed;
			bg1.Top += speed;
			bg2.Top += speed;

			int enemySpeed = baseSpeed + 2;
			enemy1.Top += enemySpeed;
			enemy2.Top += enemySpeed;

			coin1.Top += speed;

			elapsedTime++;
			if (elapsedTime % 60 == 0)
			{
				countCoins += baseCoinValue;
				labelCoins.Text = "Очки: " + countCoins;
			}


			if (elapsedTime % 600 == 0) 
			{
				baseSpeed++;
				baseCoinValue += 1;
			}

			if (coin1.Top >= 650)
			{
				coin1.Top = -50;
				coin1.Left = rand.Next(150, 560);
			}

			if (bg1.Top >= 650)
			{
				bg1.Top = 0;
				bg2.Top = -650;
			}

			if (enemy1.Top >= 650)
			{
				enemy1.Top = -200;
				enemy1.Left = rand.Next(150, 300);
			}

			if (enemy2.Top >= 650)
			{
				enemy2.Top = -500;
				enemy2.Left = rand.Next(300, 560);
			}

			CheckCollisions();
		}

		private void CheckCollisions()
		{
			if (IsPartiallyColliding(player, enemy1, 25) || IsPartiallyColliding(player, enemy2, 25))
			{
				GameOver();
			}

			if (player.Bounds.IntersectsWith(coin1.Bounds))
			{
				countCoins += 10;
				labelCoins.Text = "Очки: " + countCoins;
				coin1.Top = -50;
				coin1.Left = rand.Next(150, 560);
			}
		}

		private bool IsPartiallyColliding(Control obj1, Control obj2, int tolerance)
		{
			Rectangle obj1Bounds = new Rectangle(
				obj1.Left + tolerance, obj1.Top + tolerance,
				obj1.Width - 2 * tolerance, obj1.Height - 2 * tolerance);

			Rectangle obj2Bounds = obj2.Bounds;

			return obj1Bounds.IntersectsWith(obj2Bounds);
		}

		private void btn_StartMenu_Click(object sender, EventArgs e)
		{
			Question menuform = new Question();
			menuform.Show();
			this.Hide();
		}

		private void SaveResult(string playerName, int score)
		{
			if (!File.Exists(ResultsFilePath))
			{
				File.WriteAllText(ResultsFilePath, $"{playerName}:{score}\n");
				return;
			}

			var results = File.ReadAllLines(ResultsFilePath).ToList();

			bool nameFound = false;
			for (int i = 0; i < results.Count; i++)
			{
				string[] parts = results[i].Split(':');
				if (parts.Length != 2) continue;

				string name = parts[0];
				if (name == playerName)
				{
					nameFound = true;

					int existingScore = int.Parse(parts[1]);
					if (score > existingScore)
					{
						results[i] = $"{playerName}:{score}";
					}
					break;
				}
			}

			if (!nameFound)
			{
				results.Add($"{playerName}:{score}");
			}

			File.WriteAllLines(ResultsFilePath, results);
		}

		private void GameOver()
		{
			string playerName = "Игрок";
			SaveResult(playerName, countCoins);

			timer.Enabled = false;
			labelLose.Visible = true;
			btnRestart.Visible = true;
			lose = true;
			btn_StartMenu.Visible = true;
		}
	}
}
