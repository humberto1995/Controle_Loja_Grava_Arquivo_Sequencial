namespace Controle.Loja
{
    partial class FrmCadastroProdutos
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
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblDataUltimaCompra = new System.Windows.Forms.Label();
            this.lblValorUltimaCompra = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtValorUltimaCompra = new System.Windows.Forms.TextBox();
            this.stsCadastroProdutos = new System.Windows.Forms.StatusStrip();
            this.lblStatusExecucao = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtpDataUltimaCompra = new System.Windows.Forms.DateTimePicker();
            this.tlsCadastroProdutos = new System.Windows.Forms.ToolStrip();
            this.lblAdicionar = new System.Windows.Forms.ToolStripLabel();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.tlsSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblAlterar = new System.Windows.Forms.ToolStripLabel();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.tlsSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblExcluir = new System.Windows.Forms.ToolStripLabel();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tlsSeparador3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblGravar = new System.Windows.Forms.ToolStripLabel();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.tlsSeparador4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCancelar = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tlsSeparador5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblPesquisar = new System.Windows.Forms.ToolStripLabel();
            this.txtPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.dgvLocalidadorProdutos = new System.Windows.Forms.DataGridView();
            this.CodigoProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDadosProdutos = new System.Windows.Forms.GroupBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblObsDataUltimaCompra = new System.Windows.Forms.Label();
            this.lblObsValorUltimaCompra = new System.Windows.Forms.Label();
            this.lblObsFornecedor = new System.Windows.Forms.Label();
            this.lblObsLocalizacao = new System.Windows.Forms.Label();
            this.lblObsPrecoVenda = new System.Windows.Forms.Label();
            this.lblObsNomeProduto = new System.Windows.Forms.Label();
            this.lblObsCodigoProduto = new System.Windows.Forms.Label();
            this.gpbLocalizadorProdutos = new System.Windows.Forms.GroupBox();
            this.stsCadastroProdutos.SuspendLayout();
            this.tlsCadastroProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidadorProdutos)).BeginInit();
            this.gpbDadosProdutos.SuspendLayout();
            this.gpbLocalizadorProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(18, 32);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoProduto.TabIndex = 6;
            this.lblCodigoProduto.Text = "Código";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(18, 64);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.lblNomeProduto.TabIndex = 7;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(18, 98);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(84, 13);
            this.lblPrecoVenda.TabIndex = 8;
            this.lblPrecoVenda.Text = "Preço de Venda";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(18, 131);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(64, 13);
            this.lblLocalizacao.TabIndex = 9;
            this.lblLocalizacao.Text = "Localização";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(18, 165);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 10;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblDataUltimaCompra
            // 
            this.lblDataUltimaCompra.AutoSize = true;
            this.lblDataUltimaCompra.Location = new System.Drawing.Point(18, 199);
            this.lblDataUltimaCompra.Name = "lblDataUltimaCompra";
            this.lblDataUltimaCompra.Size = new System.Drawing.Size(101, 13);
            this.lblDataUltimaCompra.TabIndex = 11;
            this.lblDataUltimaCompra.Text = "Data Ultima Compra";
            // 
            // lblValorUltimaCompra
            // 
            this.lblValorUltimaCompra.AutoSize = true;
            this.lblValorUltimaCompra.Location = new System.Drawing.Point(18, 230);
            this.lblValorUltimaCompra.Name = "lblValorUltimaCompra";
            this.lblValorUltimaCompra.Size = new System.Drawing.Size(85, 13);
            this.lblValorUltimaCompra.TabIndex = 12;
            this.lblValorUltimaCompra.Text = "Valor de Compra";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(114, 61);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(312, 20);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(108, 95);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecoVenda.Size = new System.Drawing.Size(94, 20);
            this.txtPrecoVenda.TabIndex = 3;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(88, 128);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(149, 20);
            this.txtLocalizacao.TabIndex = 4;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(85, 162);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(257, 20);
            this.txtFornecedor.TabIndex = 5;
            // 
            // txtValorUltimaCompra
            // 
            this.txtValorUltimaCompra.Location = new System.Drawing.Point(108, 227);
            this.txtValorUltimaCompra.Name = "txtValorUltimaCompra";
            this.txtValorUltimaCompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorUltimaCompra.Size = new System.Drawing.Size(94, 20);
            this.txtValorUltimaCompra.TabIndex = 7;
            // 
            // stsCadastroProdutos
            // 
            this.stsCadastroProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusExecucao});
            this.stsCadastroProdutos.Location = new System.Drawing.Point(0, 563);
            this.stsCadastroProdutos.Name = "stsCadastroProdutos";
            this.stsCadastroProdutos.Size = new System.Drawing.Size(572, 22);
            this.stsCadastroProdutos.TabIndex = 20;
            this.stsCadastroProdutos.Text = "statusStrip1";
            // 
            // lblStatusExecucao
            // 
            this.lblStatusExecucao.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusExecucao.Name = "lblStatusExecucao";
            this.lblStatusExecucao.Size = new System.Drawing.Size(107, 17);
            this.lblStatusExecucao.Text = "Status de Execução";
            // 
            // dtpDataUltimaCompra
            // 
            this.dtpDataUltimaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUltimaCompra.Location = new System.Drawing.Point(125, 195);
            this.dtpDataUltimaCompra.Name = "dtpDataUltimaCompra";
            this.dtpDataUltimaCompra.Size = new System.Drawing.Size(103, 20);
            this.dtpDataUltimaCompra.TabIndex = 6;
            // 
            // tlsCadastroProdutos
            // 
            this.tlsCadastroProdutos.BackColor = System.Drawing.Color.Silver;
            this.tlsCadastroProdutos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAdicionar,
            this.btnAdicionar,
            this.tlsSeparador1,
            this.lblAlterar,
            this.btnAlterar,
            this.tlsSeparador2,
            this.lblExcluir,
            this.btnExcluir,
            this.tlsSeparador3,
            this.lblGravar,
            this.btnGravar,
            this.tlsSeparador4,
            this.lblCancelar,
            this.btnCancelar,
            this.tlsSeparador5,
            this.lblPesquisar,
            this.txtPesquisar,
            this.btnPesquisar});
            this.tlsCadastroProdutos.Location = new System.Drawing.Point(0, 0);
            this.tlsCadastroProdutos.Name = "tlsCadastroProdutos";
            this.tlsCadastroProdutos.Size = new System.Drawing.Size(572, 25);
            this.tlsCadastroProdutos.TabIndex = 26;
            this.tlsCadastroProdutos.Text = "toolStrip1";
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(58, 22);
            this.lblAdicionar.Text = "Adicionar";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::Controle.Loja.Properties.Resources.Icone_Aicionar;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(23, 22);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tlsSeparador1
            // 
            this.tlsSeparador1.Name = "tlsSeparador1";
            this.tlsSeparador1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblAlterar
            // 
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(42, 22);
            this.lblAlterar.Text = "Alterar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = global::Controle.Loja.Properties.Resources.Icone_Alterar;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tlsSeparador2
            // 
            this.tlsSeparador2.Name = "tlsSeparador2";
            this.tlsSeparador2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblExcluir
            // 
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(41, 22);
            this.lblExcluir.Text = "Excluir";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::Controle.Loja.Properties.Resources.Icone_Excluir;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // tlsSeparador3
            // 
            this.tlsSeparador3.Name = "tlsSeparador3";
            this.tlsSeparador3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblGravar
            // 
            this.lblGravar.Name = "lblGravar";
            this.lblGravar.Size = new System.Drawing.Size(41, 22);
            this.lblGravar.Text = "Gravar";
            // 
            // btnGravar
            // 
            this.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGravar.Image = global::Controle.Loja.Properties.Resources.Icone_Gravar;
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(23, 22);
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tlsSeparador4
            // 
            this.tlsSeparador4.Name = "tlsSeparador4";
            this.tlsSeparador4.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCancelar
            // 
            this.lblCancelar.Name = "lblCancelar";
            this.lblCancelar.Size = new System.Drawing.Size(53, 22);
            this.lblCancelar.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::Controle.Loja.Properties.Resources.Icone_Cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tlsSeparador5
            // 
            this.tlsSeparador5.Name = "tlsSeparador5";
            this.tlsSeparador5.Size = new System.Drawing.Size(6, 25);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(57, 22);
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 25);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisar.Image = global::Controle.Loja.Properties.Resources.Icone_Pesquisar;
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 20);
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvLocalidadorProdutos
            // 
            this.dgvLocalidadorProdutos.AllowUserToAddRows = false;
            this.dgvLocalidadorProdutos.AllowUserToDeleteRows = false;
            this.dgvLocalidadorProdutos.AllowUserToOrderColumns = true;
            this.dgvLocalidadorProdutos.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvLocalidadorProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidadorProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProdutos,
            this.NomeProdutos,
            this.Fornecedor});
            this.dgvLocalidadorProdutos.GridColor = System.Drawing.Color.White;
            this.dgvLocalidadorProdutos.Location = new System.Drawing.Point(10, 18);
            this.dgvLocalidadorProdutos.MultiSelect = false;
            this.dgvLocalidadorProdutos.Name = "dgvLocalidadorProdutos";
            this.dgvLocalidadorProdutos.ReadOnly = true;
            this.dgvLocalidadorProdutos.RowHeadersVisible = false;
            this.dgvLocalidadorProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalidadorProdutos.Size = new System.Drawing.Size(494, 200);
            this.dgvLocalidadorProdutos.TabIndex = 0;
            this.dgvLocalidadorProdutos.SelectionChanged += new System.EventHandler(this.dgvLocalidadorProdutos_SelectionChanged);
            // 
            // CodigoProdutos
            // 
            this.CodigoProdutos.HeaderText = "Código dos Produtos";
            this.CodigoProdutos.Name = "CodigoProdutos";
            this.CodigoProdutos.ReadOnly = true;
            this.CodigoProdutos.ToolTipText = "Código dos Produtos";
            this.CodigoProdutos.Width = 150;
            // 
            // NomeProdutos
            // 
            this.NomeProdutos.HeaderText = "Nome dos Produtos";
            this.NomeProdutos.Name = "NomeProdutos";
            this.NomeProdutos.ReadOnly = true;
            this.NomeProdutos.ToolTipText = "Nome dos Produtos";
            this.NomeProdutos.Width = 200;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.ToolTipText = "Nome do Fornecedor";
            this.Fornecedor.Width = 200;
            // 
            // gpbDadosProdutos
            // 
            this.gpbDadosProdutos.Controls.Add(this.txtCodigoProduto);
            this.gpbDadosProdutos.Controls.Add(this.lblObsDataUltimaCompra);
            this.gpbDadosProdutos.Controls.Add(this.lblObsValorUltimaCompra);
            this.gpbDadosProdutos.Controls.Add(this.lblObsFornecedor);
            this.gpbDadosProdutos.Controls.Add(this.lblObsLocalizacao);
            this.gpbDadosProdutos.Controls.Add(this.lblObsPrecoVenda);
            this.gpbDadosProdutos.Controls.Add(this.lblObsNomeProduto);
            this.gpbDadosProdutos.Controls.Add(this.lblObsCodigoProduto);
            this.gpbDadosProdutos.Controls.Add(this.lblCodigoProduto);
            this.gpbDadosProdutos.Controls.Add(this.lblNomeProduto);
            this.gpbDadosProdutos.Controls.Add(this.lblPrecoVenda);
            this.gpbDadosProdutos.Controls.Add(this.dtpDataUltimaCompra);
            this.gpbDadosProdutos.Controls.Add(this.lblLocalizacao);
            this.gpbDadosProdutos.Controls.Add(this.lblFornecedor);
            this.gpbDadosProdutos.Controls.Add(this.txtValorUltimaCompra);
            this.gpbDadosProdutos.Controls.Add(this.lblDataUltimaCompra);
            this.gpbDadosProdutos.Controls.Add(this.txtFornecedor);
            this.gpbDadosProdutos.Controls.Add(this.lblValorUltimaCompra);
            this.gpbDadosProdutos.Controls.Add(this.txtLocalizacao);
            this.gpbDadosProdutos.Controls.Add(this.txtPrecoVenda);
            this.gpbDadosProdutos.Controls.Add(this.txtNomeProduto);
            this.gpbDadosProdutos.Location = new System.Drawing.Point(26, 44);
            this.gpbDadosProdutos.Name = "gpbDadosProdutos";
            this.gpbDadosProdutos.Size = new System.Drawing.Size(517, 258);
            this.gpbDadosProdutos.TabIndex = 28;
            this.gpbDadosProdutos.TabStop = false;
            this.gpbDadosProdutos.Text = "DADOS DE PRODUROS";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(64, 29);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProduto.TabIndex = 1;
            // 
            // lblObsDataUltimaCompra
            // 
            this.lblObsDataUltimaCompra.AutoSize = true;
            this.lblObsDataUltimaCompra.Location = new System.Drawing.Point(234, 199);
            this.lblObsDataUltimaCompra.Name = "lblObsDataUltimaCompra";
            this.lblObsDataUltimaCompra.Size = new System.Drawing.Size(79, 13);
            this.lblObsDataUltimaCompra.TabIndex = 28;
            this.lblObsDataUltimaCompra.Text = "(10 Caracteres)";
            // 
            // lblObsValorUltimaCompra
            // 
            this.lblObsValorUltimaCompra.AutoSize = true;
            this.lblObsValorUltimaCompra.Location = new System.Drawing.Point(208, 230);
            this.lblObsValorUltimaCompra.Name = "lblObsValorUltimaCompra";
            this.lblObsValorUltimaCompra.Size = new System.Drawing.Size(79, 13);
            this.lblObsValorUltimaCompra.TabIndex = 27;
            this.lblObsValorUltimaCompra.Text = "(14 Caracteres)";
            // 
            // lblObsFornecedor
            // 
            this.lblObsFornecedor.AutoSize = true;
            this.lblObsFornecedor.Location = new System.Drawing.Point(358, 165);
            this.lblObsFornecedor.Name = "lblObsFornecedor";
            this.lblObsFornecedor.Size = new System.Drawing.Size(79, 13);
            this.lblObsFornecedor.TabIndex = 26;
            this.lblObsFornecedor.Text = "(15 Caracteres)";
            // 
            // lblObsLocalizacao
            // 
            this.lblObsLocalizacao.AutoSize = true;
            this.lblObsLocalizacao.Location = new System.Drawing.Point(243, 135);
            this.lblObsLocalizacao.Name = "lblObsLocalizacao";
            this.lblObsLocalizacao.Size = new System.Drawing.Size(79, 13);
            this.lblObsLocalizacao.TabIndex = 25;
            this.lblObsLocalizacao.Text = "(10 Caracteres)";
            // 
            // lblObsPrecoVenda
            // 
            this.lblObsPrecoVenda.AutoSize = true;
            this.lblObsPrecoVenda.Location = new System.Drawing.Point(208, 98);
            this.lblObsPrecoVenda.Name = "lblObsPrecoVenda";
            this.lblObsPrecoVenda.Size = new System.Drawing.Size(79, 13);
            this.lblObsPrecoVenda.TabIndex = 24;
            this.lblObsPrecoVenda.Text = "(14 Caracteres)";
            // 
            // lblObsNomeProduto
            // 
            this.lblObsNomeProduto.AutoSize = true;
            this.lblObsNomeProduto.Location = new System.Drawing.Point(432, 64);
            this.lblObsNomeProduto.Name = "lblObsNomeProduto";
            this.lblObsNomeProduto.Size = new System.Drawing.Size(79, 13);
            this.lblObsNomeProduto.TabIndex = 23;
            this.lblObsNomeProduto.Text = "(20 Caracteres)";
            // 
            // lblObsCodigoProduto
            // 
            this.lblObsCodigoProduto.AutoSize = true;
            this.lblObsCodigoProduto.Location = new System.Drawing.Point(170, 32);
            this.lblObsCodigoProduto.Name = "lblObsCodigoProduto";
            this.lblObsCodigoProduto.Size = new System.Drawing.Size(79, 13);
            this.lblObsCodigoProduto.TabIndex = 22;
            this.lblObsCodigoProduto.Text = "(10 Caracteres)";
            // 
            // gpbLocalizadorProdutos
            // 
            this.gpbLocalizadorProdutos.Controls.Add(this.dgvLocalidadorProdutos);
            this.gpbLocalizadorProdutos.Location = new System.Drawing.Point(26, 318);
            this.gpbLocalizadorProdutos.Name = "gpbLocalizadorProdutos";
            this.gpbLocalizadorProdutos.Size = new System.Drawing.Size(517, 225);
            this.gpbLocalizadorProdutos.TabIndex = 22;
            this.gpbLocalizadorProdutos.TabStop = false;
            this.gpbLocalizadorProdutos.Text = "LOCALIZADOR DE PRODUTOS";
            // 
            // FrmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(572, 585);
            this.Controls.Add(this.gpbLocalizadorProdutos);
            this.Controls.Add(this.gpbDadosProdutos);
            this.Controls.Add(this.tlsCadastroProdutos);
            this.Controls.Add(this.stsCadastroProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroProdutos";
            this.Text = "Controle Loja / Cadastro de Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroProdutos_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroProdutos_Load);
            this.stsCadastroProdutos.ResumeLayout(false);
            this.stsCadastroProdutos.PerformLayout();
            this.tlsCadastroProdutos.ResumeLayout(false);
            this.tlsCadastroProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidadorProdutos)).EndInit();
            this.gpbDadosProdutos.ResumeLayout(false);
            this.gpbDadosProdutos.PerformLayout();
            this.gpbLocalizadorProdutos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblDataUltimaCompra;
        private System.Windows.Forms.Label lblValorUltimaCompra;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPrecoVenda;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtValorUltimaCompra;
        private System.Windows.Forms.StatusStrip stsCadastroProdutos;
        private System.Windows.Forms.DateTimePicker dtpDataUltimaCompra;
        private System.Windows.Forms.ToolStrip tlsCadastroProdutos;
        private System.Windows.Forms.ToolStripLabel lblAdicionar;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripSeparator tlsSeparador1;
        private System.Windows.Forms.ToolStripLabel lblAlterar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripSeparator tlsSeparador2;
        private System.Windows.Forms.ToolStripLabel lblExcluir;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator tlsSeparador3;
        private System.Windows.Forms.ToolStripLabel lblGravar;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripSeparator tlsSeparador4;
        private System.Windows.Forms.ToolStripLabel lblCancelar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator tlsSeparador5;
        private System.Windows.Forms.ToolStripLabel lblPesquisar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisar;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.DataGridView dgvLocalidadorProdutos;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusExecucao;
        private System.Windows.Forms.GroupBox gpbDadosProdutos;
        private System.Windows.Forms.GroupBox gpbLocalizadorProdutos;
        private System.Windows.Forms.Label lblObsDataUltimaCompra;
        private System.Windows.Forms.Label lblObsValorUltimaCompra;
        private System.Windows.Forms.Label lblObsFornecedor;
        private System.Windows.Forms.Label lblObsLocalizacao;
        private System.Windows.Forms.Label lblObsPrecoVenda;
        private System.Windows.Forms.Label lblObsNomeProduto;
        private System.Windows.Forms.Label lblObsCodigoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.TextBox txtCodigoProduto;
    }
}

