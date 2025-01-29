namespace FirstGame
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.labelLose = new System.Windows.Forms.Label();
			this.btnRestart = new System.Windows.Forms.Button();
			this.labelCoins = new System.Windows.Forms.Label();
			this.btn_StartMenu = new System.Windows.Forms.Button();
			this.coin1 = new System.Windows.Forms.PictureBox();
			this.coin = new System.Windows.Forms.PictureBox();
			this.enemy2 = new System.Windows.Forms.PictureBox();
			this.enemy1 = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.bg1 = new System.Windows.Forms.PictureBox();
			this.bg2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 15;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// labelLose
			// 
			this.labelLose.AutoSize = true;
			this.labelLose.BackColor = System.Drawing.Color.Red;
			this.labelLose.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLose.Location = new System.Drawing.Point(272, 168);
			this.labelLose.Name = "labelLose";
			this.labelLose.Size = new System.Drawing.Size(302, 67);
			this.labelLose.TabIndex = 5;
			this.labelLose.Text = "YOU LOSE.";
			// 
			// btnRestart
			// 
			this.btnRestart.BackColor = System.Drawing.Color.DarkGray;
			this.btnRestart.FlatAppearance.BorderSize = 0;
			this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRestart.Location = new System.Drawing.Point(340, 261);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new System.Drawing.Size(166, 61);
			this.btnRestart.TabIndex = 6;
			this.btnRestart.Text = "Restart";
			this.btnRestart.UseVisualStyleBackColor = false;
			this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
			// 
			// labelCoins
			// 
			this.labelCoins.AutoSize = true;
			this.labelCoins.BackColor = System.Drawing.Color.Red;
			this.labelCoins.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCoins.Location = new System.Drawing.Point(26, 9);
			this.labelCoins.Name = "labelCoins";
			this.labelCoins.Size = new System.Drawing.Size(123, 38);
			this.labelCoins.TabIndex = 8;
			this.labelCoins.Text = "Очки: 0";
			// 
			// btn_StartMenu
			// 
			this.btn_StartMenu.BackColor = System.Drawing.Color.DarkGray;
			this.btn_StartMenu.FlatAppearance.BorderSize = 0;
			this.btn_StartMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_StartMenu.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_StartMenu.Location = new System.Drawing.Point(340, 348);
			this.btn_StartMenu.Name = "btn_StartMenu";
			this.btn_StartMenu.Size = new System.Drawing.Size(166, 61);
			this.btn_StartMenu.TabIndex = 9;
			this.btn_StartMenu.Text = "Menu";
			this.btn_StartMenu.UseVisualStyleBackColor = false;
			this.btn_StartMenu.Click += new System.EventHandler(this.btn_StartMenu_Click);
			// 
			// coin1
			// 
			this.coin1.Image = global::FirstGame.Properties.Resources._5310117_coin_dollar_money_icon;
			this.coin1.Location = new System.Drawing.Point(456, -500);
			this.coin1.Name = "coin1";
			this.coin1.Size = new System.Drawing.Size(50, 50);
			this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin1.TabIndex = 10;
			this.coin1.TabStop = false;
			// 
			// coin
			// 
			this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
			this.coin.Location = new System.Drawing.Point(466, -550);
			this.coin.Name = "coin";
			this.coin.Size = new System.Drawing.Size(50, 50);
			this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.coin.TabIndex = 7;
			this.coin.TabStop = false;
			// 
			// enemy2
			// 
			this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
			this.enemy2.Location = new System.Drawing.Point(548, -400);
			this.enemy2.Name = "enemy2";
			this.enemy2.Size = new System.Drawing.Size(128, 148);
			this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy2.TabIndex = 4;
			this.enemy2.TabStop = false;
			// 
			// enemy1
			// 
			this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
			this.enemy1.Location = new System.Drawing.Point(166, -150);
			this.enemy1.Name = "enemy1";
			this.enemy1.Size = new System.Drawing.Size(128, 148);
			this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.enemy1.TabIndex = 3;
			this.enemy1.TabStop = false;
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.player.Image = global::FirstGame.Properties.Resources._1678364049;
			this.player.Location = new System.Drawing.Point(442, 483);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(86, 155);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.player.TabIndex = 1;
			this.player.TabStop = false;
			// 
			// bg1
			// 
			this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
			this.bg1.Location = new System.Drawing.Point(0, 0);
			this.bg1.Name = "bg1";
			this.bg1.Size = new System.Drawing.Size(840, 650);
			this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.bg1.TabIndex = 0;
			this.bg1.TabStop = false;
			// 
			// bg2
			// 
			this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
			this.bg2.Location = new System.Drawing.Point(0, -650);
			this.bg2.Name = "bg2";
			this.bg2.Size = new System.Drawing.Size(840, 650);
			this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.bg2.TabIndex = 2;
			this.bg2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(840, 650);
			this.Controls.Add(this.coin1);
			this.Controls.Add(this.btn_StartMenu);
			this.Controls.Add(this.labelLose);
			this.Controls.Add(this.btnRestart);
			this.Controls.Add(this.labelCoins);
			this.Controls.Add(this.coin);
			this.Controls.Add(this.enemy2);
			this.Controls.Add(this.enemy1);
			this.Controls.Add(this.player);
			this.Controls.Add(this.bg1);
			this.Controls.Add(this.bg2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox bg1;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.PictureBox bg2;
		private System.Windows.Forms.PictureBox enemy1;
		private System.Windows.Forms.PictureBox enemy2;
		private System.Windows.Forms.Label labelLose;
		private System.Windows.Forms.Button btnRestart;
		private System.Windows.Forms.PictureBox coin;
		private System.Windows.Forms.Label labelCoins;
		private System.Windows.Forms.Button btn_StartMenu;
		private System.Windows.Forms.PictureBox coin1;
	}
}

