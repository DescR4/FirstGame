using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGame
{
	public partial class Question : Form
	{
		public Question()
		{
			InitializeComponent();
		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			Form1 gameForm = new Form1();
			gameForm.Show();
			this.Hide();
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
