namespace APP_Cadastro_Funcionário
{
	partial class FormCad
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
            System.Windows.Forms.Label certificado_Reservista_RALabel;
            System.Windows.Forms.Label título_EleitorLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label correio_EletrônicoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label estado_CivilLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCad));
            System.Windows.Forms.Label finalidadeLabel;
            System.Windows.Forms.Label emailLabel;
            this.database3DataSet = new APP_Cadastro_Funcionário.Database3DataSet();
            this.cadFuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadFuncTableAdapter = new APP_Cadastro_Funcionário.Database3DataSetTableAdapters.CadFuncTableAdapter();
            this.tableAdapterManager = new APP_Cadastro_Funcionário.Database3DataSetTableAdapters.TableAdapterManager();
            this.cadFuncBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadFuncBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDFuncinárioTextBox = new System.Windows.Forms.TextBox();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.certificado_Reservista_RATextBox = new System.Windows.Forms.TextBox();
            this.título_EleitorTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.estado_CivilTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.finalidadeComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            iDFuncinárioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_de_NascimentoLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            certificado_Reservista_RALabel = new System.Windows.Forms.Label();
            título_EleitorLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            correio_EletrônicoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            estado_CivilLabel = new System.Windows.Forms.Label();
            finalidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingNavigator)).BeginInit();
            this.cadFuncBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDFuncinárioLabel
            // 
            iDFuncinárioLabel.AutoSize = true;
            iDFuncinárioLabel.Location = new System.Drawing.Point(12, 451);
            iDFuncinárioLabel.Name = "iDFuncinárioLabel";
            iDFuncinárioLabel.Size = new System.Drawing.Size(70, 13);
            iDFuncinárioLabel.TabIndex = 37;
            iDFuncinárioLabel.Text = "IDFuncinário:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 19;
            nomeLabel.Text = "Nome:";
            // 
            // data_de_NascimentoLabel
            // 
            data_de_NascimentoLabel.AutoSize = true;
            data_de_NascimentoLabel.Location = new System.Drawing.Point(12, 69);
            data_de_NascimentoLabel.Name = "data_de_NascimentoLabel";
            data_de_NascimentoLabel.Size = new System.Drawing.Size(107, 13);
            data_de_NascimentoLabel.TabIndex = 20;
            data_de_NascimentoLabel.Text = "Data de Nascimento:";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(12, 178);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 24;
            cPFLabel.Text = "CPF:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(12, 204);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 25;
            rGLabel.Text = "RG:";
            // 
            // certificado_Reservista_RALabel
            // 
            certificado_Reservista_RALabel.AutoSize = true;
            certificado_Reservista_RALabel.Location = new System.Drawing.Point(12, 257);
            certificado_Reservista_RALabel.Name = "certificado_Reservista_RALabel";
            certificado_Reservista_RALabel.Size = new System.Drawing.Size(70, 13);
            certificado_Reservista_RALabel.TabIndex = 28;
            certificado_Reservista_RALabel.Text = "Valor Minimo:";
            // 
            // título_EleitorLabel
            // 
            título_EleitorLabel.AutoSize = true;
            título_EleitorLabel.Location = new System.Drawing.Point(12, 283);
            título_EleitorLabel.Name = "título_EleitorLabel";
            título_EleitorLabel.Size = new System.Drawing.Size(68, 13);
            título_EleitorLabel.TabIndex = 29;
            título_EleitorLabel.Text = "Valor Máimo:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 95);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 21;
            telefoneLabel.Text = "Telefone:";
            // 
            // correio_EletrônicoLabel
            // 
            correio_EletrônicoLabel.AutoSize = true;
            correio_EletrônicoLabel.Location = new System.Drawing.Point(12, 121);
            correio_EletrônicoLabel.Name = "correio_EletrônicoLabel";
            correio_EletrônicoLabel.Size = new System.Drawing.Size(42, 13);
            correio_EletrônicoLabel.TabIndex = 22;
            correio_EletrônicoLabel.Text = "Celular:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(397, 43);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 32;
            cidadeLabel.Text = "Cidade:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(397, 69);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 33;
            estadoLabel.Text = "Estado:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(397, 95);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 34;
            paisLabel.Text = "Pais:";
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(397, 121);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(56, 13);
            endereçoLabel.TabIndex = 35;
            endereçoLabel.Text = "Endereço:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(397, 147);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 36;
            cEPLabel.Text = "CEP:";
            // 
            // estado_CivilLabel
            // 
            estado_CivilLabel.AutoSize = true;
            estado_CivilLabel.Location = new System.Drawing.Point(12, 149);
            estado_CivilLabel.Name = "estado_CivilLabel";
            estado_CivilLabel.Size = new System.Drawing.Size(65, 13);
            estado_CivilLabel.TabIndex = 23;
            estado_CivilLabel.Text = "Estado Civil:";
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadFuncBindingSource
            // 
            this.cadFuncBindingSource.DataMember = "CadFunc";
            this.cadFuncBindingSource.DataSource = this.database3DataSet;
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
            // cadFuncBindingNavigator
            // 
            this.cadFuncBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cadFuncBindingNavigator.BindingSource = this.cadFuncBindingSource;
            this.cadFuncBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cadFuncBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cadFuncBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cadFuncBindingNavigatorSaveItem});
            this.cadFuncBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cadFuncBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cadFuncBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cadFuncBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cadFuncBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cadFuncBindingNavigator.Name = "cadFuncBindingNavigator";
            this.cadFuncBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cadFuncBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cadFuncBindingNavigator.TabIndex = 0;
            this.cadFuncBindingNavigator.Text = "bindingNavigator1";
            this.cadFuncBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cadFuncBindingNavigatorSaveItem
            // 
            this.cadFuncBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadFuncBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadFuncBindingNavigatorSaveItem.Image")));
            this.cadFuncBindingNavigatorSaveItem.Name = "cadFuncBindingNavigatorSaveItem";
            this.cadFuncBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cadFuncBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cadFuncBindingNavigatorSaveItem.Click += new System.EventHandler(this.cadFuncBindingNavigatorSaveItem_Click);
            // 
            // iDFuncinárioTextBox
            // 
            this.iDFuncinárioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "IDFuncinário", true));
            this.iDFuncinárioTextBox.Location = new System.Drawing.Point(151, 448);
            this.iDFuncinárioTextBox.Name = "iDFuncinárioTextBox";
            this.iDFuncinárioTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDFuncinárioTextBox.TabIndex = 17;
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Nome", true));
            this.NomeTextBox.Location = new System.Drawing.Point(151, 40);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(230, 20);
            this.NomeTextBox.TabIndex = 0;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(151, 175);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox.TabIndex = 5;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(151, 201);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(100, 20);
            this.rGTextBox.TabIndex = 6;
            // 
            // certificado_Reservista_RATextBox
            // 
            this.certificado_Reservista_RATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Valor Minimo", true));
            this.certificado_Reservista_RATextBox.Location = new System.Drawing.Point(151, 254);
            this.certificado_Reservista_RATextBox.Name = "certificado_Reservista_RATextBox";
            this.certificado_Reservista_RATextBox.Size = new System.Drawing.Size(100, 20);
            this.certificado_Reservista_RATextBox.TabIndex = 9;
            // 
            // título_EleitorTextBox
            // 
            this.título_EleitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Valor Máximo", true));
            this.título_EleitorTextBox.Location = new System.Drawing.Point(151, 280);
            this.título_EleitorTextBox.Name = "título_EleitorTextBox";
            this.título_EleitorTextBox.Size = new System.Drawing.Size(100, 20);
            this.título_EleitorTextBox.TabIndex = 10;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(473, 40);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 12;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(473, 92);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 20);
            this.paisTextBox.TabIndex = 14;
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(473, 118);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(236, 20);
            this.endereçoTextBox.TabIndex = 15;
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(473, 144);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEPTextBox.TabIndex = 16;
            // 
            // estado_CivilTextBox
            // 
            this.estado_CivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Estado Civil", true));
            this.estado_CivilTextBox.Location = new System.Drawing.Point(151, 146);
            this.estado_CivilTextBox.Name = "estado_CivilTextBox";
            this.estado_CivilTextBox.Size = new System.Drawing.Size(100, 20);
            this.estado_CivilTextBox.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Telefone", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(151, 92);
            this.maskedTextBox1.Mask = "(99) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Data de Nascimento", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(151, 66);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(151, 118);
            this.maskedTextBox3.Mask = "(99) 00000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 2;
            // 
            // finalidadeLabel
            // 
            finalidadeLabel.AutoSize = true;
            finalidadeLabel.Location = new System.Drawing.Point(12, 230);
            finalidadeLabel.Name = "finalidadeLabel";
            finalidadeLabel.Size = new System.Drawing.Size(58, 13);
            finalidadeLabel.TabIndex = 37;
            finalidadeLabel.Text = "Finalidade:";
            // 
            // finalidadeComboBox
            // 
            this.finalidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Finalidade", true));
            this.finalidadeComboBox.FormattingEnabled = true;
            this.finalidadeComboBox.Items.AddRange(new object[] {
            "Compra",
            "Venda",
            "Aluguel"});
            this.finalidadeComboBox.Location = new System.Drawing.Point(151, 227);
            this.finalidadeComboBox.Name = "finalidadeComboBox";
            this.finalidadeComboBox.Size = new System.Drawing.Size(100, 21);
            this.finalidadeComboBox.TabIndex = 38;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 309);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 38;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(151, 306);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(208, 20);
            this.emailTextBox.TabIndex = 39;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadFuncBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.estadoComboBox.Location = new System.Drawing.Point(473, 66);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(100, 21);
            this.estadoComboBox.TabIndex = 40;
            // 
            // FormCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 488);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(finalidadeLabel);
            this.Controls.Add(this.finalidadeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(iDFuncinárioLabel);
            this.Controls.Add(this.iDFuncinárioTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(data_de_NascimentoLabel);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(certificado_Reservista_RALabel);
            this.Controls.Add(this.certificado_Reservista_RATextBox);
            this.Controls.Add(título_EleitorLabel);
            this.Controls.Add(this.título_EleitorTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(correio_EletrônicoLabel);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(endereçoLabel);
            this.Controls.Add(this.endereçoTextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPTextBox);
            this.Controls.Add(estado_CivilLabel);
            this.Controls.Add(this.estado_CivilTextBox);
            this.Controls.Add(this.cadFuncBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrando - Funcionário";
            this.Load += new System.EventHandler(this.FormCad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadFuncBindingNavigator)).EndInit();
            this.cadFuncBindingNavigator.ResumeLayout(false);
            this.cadFuncBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Database3DataSet database3DataSet;
		private System.Windows.Forms.BindingSource cadFuncBindingSource;
		private Database3DataSetTableAdapters.CadFuncTableAdapter cadFuncTableAdapter;
		private Database3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator cadFuncBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton cadFuncBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox iDFuncinárioTextBox;
		private System.Windows.Forms.TextBox NomeTextBox;
		private System.Windows.Forms.TextBox cPFTextBox;
		private System.Windows.Forms.TextBox rGTextBox;
		private System.Windows.Forms.TextBox certificado_Reservista_RATextBox;
		private System.Windows.Forms.TextBox título_EleitorTextBox;
		private System.Windows.Forms.TextBox cidadeTextBox;
		private System.Windows.Forms.TextBox paisTextBox;
		private System.Windows.Forms.TextBox endereçoTextBox;
		private System.Windows.Forms.TextBox cEPTextBox;
		private System.Windows.Forms.TextBox estado_CivilTextBox;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.ComboBox finalidadeComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
    }
}