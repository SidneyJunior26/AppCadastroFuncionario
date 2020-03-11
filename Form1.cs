using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Cadastro_Funcionário
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lbldata.Text = DateTime.Now.ToString();
		}

		private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCad FormCad2 = new FormCad();
			FormCad2.ShowDialog();
		}

		private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormConsulta FormCad3 = new FormConsulta();
			FormCad3.ShowDialog();
		}
	}
}
