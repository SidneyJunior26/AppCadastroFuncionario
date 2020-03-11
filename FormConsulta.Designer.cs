namespace APP_Cadastro_Funcionário
{
	partial class FormConsulta
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
            System.Windows.Forms.Label iDFuncinárioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_de_NascimentoLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label correio_EletrônicoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label estado_CivilLabel;
            System.Windows.Forms.Label finalidadeLabel;
            System.Windows.Forms.Label valor_MinimoLabel;
            System.Windows.Forms.Label valor_MáximoLabel;
            System.Windows.Forms.Label emailLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cadFuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database3DataSet = new APP_Cadastro_Funcionário.Database3DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.database3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadFuncTableAdapter = new APP_Cadastro_Funcionário.Database3DataSetTableAdapters.CadFuncTableAdapter();
            this.tableAdapterManager = new APP_Cadastro_Funcionário.Database3DataSetTableAdapters.TableAdapterManager();
            this.iDFuncinárioTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.estado_CivilTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.finalidadeComboBox = new System.Windows.Forms.ComboBox();
            this.valor_MinimoTextBox = new System.Windows.Forms.TextBox();
            this.valor_MáximoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            iDFuncinárioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_de_NascimentoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            correio_EletrônicoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            estado_CivilLabel = new System.Windows.Forms.Label();
            finalidadeLabel = new System.Windows.Forms.Label();
            valor_MinimoLabel = new System.Windows.Forms.Label();
            valor_MáximoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDFuncinárioLabel
            // 
            iDFuncinárioLabel.AutoSize = true;
            iDFuncinárioLabel.Location = new System.Drawing.Point(484, 350);
            iDFuncinárioLabel.Name = "iDFuncinárioLabel";
            iDFuncinárioLabel.Size = new System.Drawing.Size(70, 13);
            iDFuncinárioLabel.TabIndex = 54;
            iDFuncinárioLabel.Text = "IDFuncinário:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(23, 90);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 56;
            nomeLabel.Text = "Nome:";
            // 
            // data_de_NascimentoLabel
            // 
            data_de_NascimentoLabel.AutoSize = true;
            data_de_NascimentoLabel.Location = new System.Drawing.Point(23, 116);
            data_de_NascimentoLabel.Name = "data_de_NascimentoLabel";
            data_de_NascimentoLabel.Size = new System.Drawing.Size(107, 13);
            data_de_NascimentoLabel.TabIndex = 58;
            data_de_NascimentoLabel.Text = "Data de Nascimento:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(23, 221);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 60;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(23, 247);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 62;
            rGLabel.Text = "RG:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(23, 169);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 74;
            telefoneLabel.Text = "Telefone:";
            // 
            // correio_EletrônicoLabel
            // 
            correio_EletrônicoLabel.AutoSize = true;
            correio_EletrônicoLabel.Location = new System.Drawing.Point(23, 195);
            correio_EletrônicoLabel.Name = "correio_EletrônicoLabel";
            correio_EletrônicoLabel.Size = new System.Drawing.Size(39, 13);
            correio_EletrônicoLabel.TabIndex = 76;
            correio_EletrônicoLabel.Text = "Celular";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(484, 87);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 78;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(484, 113);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 80;
            estadoLabel.Text = "Estado:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(484, 139);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 82;
            paisLabel.Text = "Pais:";
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(484, 165);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(56, 13);
            endereçoLabel.TabIndex = 84;
            endereçoLabel.Text = "Endereço:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(484, 191);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 86;
            cEPLabel.Text = "CEP:";
            // 
            // estado_CivilLabel
            // 
            estado_CivilLabel.AutoSize = true;
            estado_CivilLabel.Location = new System.Drawing.Point(23, 143);
            estado_CivilLabel.Name = "estado_CivilLabel";
            estado_CivilLabel.Size = new System.Drawing.Size(65, 13);
            estado_CivilLabel.TabIndex = 88;
            estado_CivilLabel.Text = "Estado Civil:";
            // 
            // finalidadeLabel
            // 
            finalidadeLabel.AutoSize = true;
            finalidadeLabel.Location = new System.Drawing.Point(22, 273);
            finalidadeLabel.Name = "finalidadeLabel";
            finalidadeLabel.Size = new System.Drawing.Size(58, 13);
            finalidadeLabel.TabIndex = 91;
            finalidadeLabel.Text = "Finalidade:";
            // 
            // valor_MinimoLabel
            // 
            valor_MinimoLabel.AutoSize = true;
            valor_MinimoLabel.Location = new System.Drawing.Point(23, 298);
            valor_MinimoLabel.Name = "valor_MinimoLabel";
            valor_MinimoLabel.Size = new System.Drawing.Size(70, 13);
            valor_MinimoLabel.TabIndex = 92;
            valor_MinimoLabel.Text = "Valor Minimo:";
            // 
            // valor_MáximoLabel
            // 
            valor_MáximoLabel.AutoSize = true;
            valor_MáximoLabel.Location = new System.Drawing.Point(23, 323);
            valor_MáximoLabel.Name = "valor_MáximoLabel";
            valor_MáximoLabel.Size = new System.Drawing.Size(73, 13);
            valor_MáximoLabel.TabIndex = 93;
            valor_MáximoLabel.Text = "Valor Máximo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Funcionário:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.cadFuncBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "IDFuncinário";
            // 
            // cadFuncBindingSource
            // 
            this.cadFuncBindingSource.DataMember = "CadFunc";
            this.cadFuncBindingSource.DataSource = this.database3DataSet;
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database3DataSetBindingSource
            // 
            this.database3DataSetBindingSource.DataSource = this.database3DataSet;
            this.database3DataSetBindingSource.Position = 0;
            // 
            // cadFuncTableAdapter
            // 
            this.cadFuncTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadFuncTableAdapter = this.cadFuncTableAdapter;
            this.tableAdapterManager.UpdateOrder = APP_Cadastro_Funcionário.Database3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDFuncinárioTextBox
            // 
            this.iDFuncinárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "IDFuncinário", true));
            this.iDFuncinárioTextBox.Location = new System.Drawing.Point(623, 347);
            this.iDFuncinárioTextBox.Name = "iDFuncinárioTextBox";
            this.iDFuncinárioTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDFuncinárioTextBox.TabIndex = 55;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(162, 87);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(303, 20);
            this.nomeTextBox.TabIndex = 57;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(162, 218);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox.TabIndex = 61;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(162, 244);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(100, 20);
            this.rGTextBox.TabIndex = 63;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(623, 84);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 79;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(623, 110);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 81;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(623, 136);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 20);
            this.paisTextBox.TabIndex = 83;
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(623, 162);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(100, 20);
            this.endereçoTextBox.TabIndex = 85;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(623, 188);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEPTextBox.TabIndex = 87;
            // 
            // estado_CivilTextBox
            // 
            this.estado_CivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Estado Civil", true));
            this.estado_CivilTextBox.Location = new System.Drawing.Point(162, 140);
            this.estado_CivilTextBox.Name = "estado_CivilTextBox";
            this.estado_CivilTextBox.Size = new System.Drawing.Size(100, 20);
            this.estado_CivilTextBox.TabIndex = 89;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Data de Nascimento", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(162, 113);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBox1.TabIndex = 90;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Telefone", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(162, 166);
            this.maskedTextBox2.Mask = "(99) 0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 91;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Celular", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(162, 192);
            this.maskedTextBox3.Mask = "(99) 00000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 91;
            // 
            // finalidadeComboBox
            // 
            this.finalidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Finalidade", true));
            this.finalidadeComboBox.FormattingEnabled = true;
            this.finalidadeComboBox.Items.AddRange(new object[] {
            "Compra",
            "Venda",
            "Aluguel"});
            this.finalidadeComboBox.Location = new System.Drawing.Point(162, 269);
            this.finalidadeComboBox.Name = "finalidadeComboBox";
            this.finalidadeComboBox.Size = new System.Drawing.Size(100, 21);
            this.finalidadeComboBox.TabIndex = 92;
            // 
            // valor_MinimoTextBox
            // 
            this.valor_MinimoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Valor Minimo", true));
            this.valor_MinimoTextBox.Location = new System.Drawing.Point(162, 295);
            this.valor_MinimoTextBox.Name = "valor_MinimoTextBox";
            this.valor_MinimoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_MinimoTextBox.TabIndex = 93;
            // 
            // valor_MáximoTextBox
            // 
            this.valor_MáximoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Valor Máximo", true));
            this.valor_MáximoTextBox.Location = new System.Drawing.Point(162, 320);
            this.valor_MáximoTextBox.Name = "valor_MáximoTextBox";
            this.valor_MáximoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valor_MáximoTextBox.TabIndex = 94;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 349);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 94;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(162, 346);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(196, 20);
            this.emailTextBox.TabIndex = 95;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 416);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(valor_MáximoLabel);
            this.Controls.Add(this.valor_MáximoTextBox);
            this.Controls.Add(valor_MinimoLabel);
            this.Controls.Add(this.valor_MinimoTextBox);
            this.Controls.Add(finalidadeLabel);
            this.Controls.Add(this.finalidadeComboBox);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(iDFuncinárioLabel);
            this.Controls.Add(this.iDFuncinárioTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_de_NascimentoLabel);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(correio_EletrônicoLabel);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(endereçoLabel);
            this.Controls.Add(this.endereçoTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(estado_CivilLabel);
            this.Controls.Add(this.estado_CivilTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsulta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Consultando - Funcionário";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource database3DataSetBindingSource;
		private Database3DataSet database3DataSet;
		private System.Windows.Forms.BindingSource cadFuncBindingSource;
		private Database3DataSetTableAdapters.CadFuncTableAdapter cadFuncTableAdapter;
		private Database3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox iDFuncinárioTextBox;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.TextBox cPFTextBox;
		private System.Windows.Forms.TextBox rGTextBox;
		private System.Windows.Forms.TextBox cidadeTextBox;
		private System.Windows.Forms.TextBox estadoTextBox;
		private System.Windows.Forms.TextBox paisTextBox;
		private System.Windows.Forms.TextBox endereçoTextBox;
		private System.Windows.Forms.TextBox cEPTextBox;
		private System.Windows.Forms.TextBox estado_CivilTextBox;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox finalidadeComboBox;
        private System.Windows.Forms.TextBox valor_MinimoTextBox;
        private System.Windows.Forms.TextBox valor_MáximoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}