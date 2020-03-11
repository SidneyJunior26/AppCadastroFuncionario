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
	public partial class FormCad : Form
	{
		public FormCad()
		{
			InitializeComponent();
		}

		private void cadFuncBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.cadFuncBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database3DataSet);

		}

		private void FormCad_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'database3DataSet.CadFunc'. Você pode movê-la ou removê-la conforme necessário.
			this.cadFuncTableAdapter.Fill(this.database3DataSet.CadFunc);
			this.cadFuncBindingSource.AddNew();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.cadFuncBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.database3DataSet);
		}
	}
}
