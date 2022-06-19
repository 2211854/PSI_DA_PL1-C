namespace RestGest
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdicionar = new System.Windows.Forms.TabPage();
            this.tabPageConsultar = new System.Windows.Forms.TabPage();
            this.groupBoxMenusPedidos = new System.Windows.Forms.GroupBox();
            this.listBoxListaMenus = new System.Windows.Forms.ListBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBoxListaPedidos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNomeClienteValor = new System.Windows.Forms.Label();
            this.labelMoradaValor = new System.Windows.Forms.Label();
            this.labelEstadoAtual = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalValor = new System.Windows.Forms.Label();
            this.comboBoxEstadoAtual = new System.Windows.Forms.ComboBox();
            this.groupBoxAdcMenusPedidos = new System.Windows.Forms.GroupBox();
            this.listBoxMenusPedidos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelAdcMoradaCliente = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxAdicionarMenu = new System.Windows.Forms.GroupBox();
            this.labelDesignacaoProduto = new System.Windows.Forms.Label();
            this.comboBoxAdicionarMenu = new System.Windows.Forms.ComboBox();
            this.labelQuantidadeProduto = new System.Windows.Forms.Label();
            this.buttonAdcRemoverMenu = new System.Windows.Forms.Button();
            this.comboBoxAdcCliente = new System.Windows.Forms.ComboBox();
            this.labelAdcContribuinteCliente = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxQuantidadeMenu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRemoverMenu = new System.Windows.Forms.Button();
            this.labelMetodoPagamento = new System.Windows.Forms.Label();
            this.listBoxMetodoPagamento = new System.Windows.Forms.ListBox();
            this.listBoxAdcMetodoPagamento = new System.Windows.Forms.ListBox();
            this.labelAdcTotalValor = new System.Windows.Forms.Label();
            this.labelAdcTotal = new System.Windows.Forms.Label();
            this.labelAdcMetodoPagamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageAdicionar.SuspendLayout();
            this.tabPageConsultar.SuspendLayout();
            this.groupBoxMenusPedidos.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxListaPedidos.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.groupBoxAdcMenusPedidos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAdicionarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdicionar);
            this.tabControl1.Controls.Add(this.tabPageConsultar);
            this.tabControl1.Location = new System.Drawing.Point(17, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 599);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageAdicionar
            // 
            this.tabPageAdicionar.Controls.Add(this.groupBoxAdicionarMenu);
            this.tabPageAdicionar.Controls.Add(this.groupBoxAdcMenusPedidos);
            this.tabPageAdicionar.Controls.Add(this.groupBox3);
            this.tabPageAdicionar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdicionar.Name = "tabPageAdicionar";
            this.tabPageAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdicionar.Size = new System.Drawing.Size(1033, 573);
            this.tabPageAdicionar.TabIndex = 0;
            this.tabPageAdicionar.Text = "Adicionar";
            this.tabPageAdicionar.UseVisualStyleBackColor = true;
            // 
            // tabPageConsultar
            // 
            this.tabPageConsultar.Controls.Add(this.groupBoxEstado);
            this.tabPageConsultar.Controls.Add(this.groupBoxMenusPedidos);
            this.tabPageConsultar.Controls.Add(this.groupBoxCliente);
            this.tabPageConsultar.Controls.Add(this.groupBoxListaPedidos);
            this.tabPageConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultar.Name = "tabPageConsultar";
            this.tabPageConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultar.Size = new System.Drawing.Size(1033, 573);
            this.tabPageConsultar.TabIndex = 1;
            this.tabPageConsultar.Text = "Consultar";
            this.tabPageConsultar.UseVisualStyleBackColor = true;
            this.tabPageConsultar.Click += new System.EventHandler(this.tabPageConsultar_Click);
            // 
            // groupBoxMenusPedidos
            // 
            this.groupBoxMenusPedidos.Controls.Add(this.listBoxMetodoPagamento);
            this.groupBoxMenusPedidos.Controls.Add(this.labelTotalValor);
            this.groupBoxMenusPedidos.Controls.Add(this.labelTotal);
            this.groupBoxMenusPedidos.Controls.Add(this.buttonRemoverMenu);
            this.groupBoxMenusPedidos.Controls.Add(this.listBoxListaMenus);
            this.groupBoxMenusPedidos.Controls.Add(this.labelMetodoPagamento);
            this.groupBoxMenusPedidos.Location = new System.Drawing.Point(269, 162);
            this.groupBoxMenusPedidos.Name = "groupBoxMenusPedidos";
            this.groupBoxMenusPedidos.Size = new System.Drawing.Size(743, 387);
            this.groupBoxMenusPedidos.TabIndex = 4;
            this.groupBoxMenusPedidos.TabStop = false;
            this.groupBoxMenusPedidos.Text = "Lista Menus Pedidos";
            this.groupBoxMenusPedidos.Enter += new System.EventHandler(this.groupBoxMenusPedidos_Enter);
            // 
            // listBoxListaMenus
            // 
            this.listBoxListaMenus.FormattingEnabled = true;
            this.listBoxListaMenus.Location = new System.Drawing.Point(16, 29);
            this.listBoxListaMenus.Name = "listBoxListaMenus";
            this.listBoxListaMenus.Size = new System.Drawing.Size(560, 316);
            this.listBoxListaMenus.TabIndex = 1;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.label3);
            this.groupBoxCliente.Controls.Add(this.labelMoradaValor);
            this.groupBoxCliente.Controls.Add(this.label8);
            this.groupBoxCliente.Controls.Add(this.labelNomeClienteValor);
            this.groupBoxCliente.Controls.Add(this.labelMorada);
            this.groupBoxCliente.Controls.Add(this.labelNomeCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(269, 17);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(365, 122);
            this.groupBoxCliente.TabIndex = 3;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(25, 30);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCliente.TabIndex = 2;
            this.labelNomeCliente.Text = "Nome";
            // 
            // groupBoxListaPedidos
            // 
            this.groupBoxListaPedidos.Controls.Add(this.label1);
            this.groupBoxListaPedidos.Controls.Add(this.comboBoxFiltro);
            this.groupBoxListaPedidos.Controls.Add(this.listBoxPedidos);
            this.groupBoxListaPedidos.Location = new System.Drawing.Point(20, 96);
            this.groupBoxListaPedidos.Name = "groupBoxListaPedidos";
            this.groupBoxListaPedidos.Size = new System.Drawing.Size(243, 453);
            this.groupBoxListaPedidos.TabIndex = 2;
            this.groupBoxListaPedidos.TabStop = false;
            this.groupBoxListaPedidos.Text = "Lista de Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro:";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFiltro.DisplayMember = "0";
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todos",
            "Terminados",
            "Cancelados",
            "Em curso"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(63, 41);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(151, 21);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(28, 79);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(186, 355);
            this.listBoxPedidos.TabIndex = 0;
            // 
            // groupBoxEstado
            // 
            this.groupBoxEstado.Controls.Add(this.labelEstadoAtual);
            this.groupBoxEstado.Controls.Add(this.comboBoxEstadoAtual);
            this.groupBoxEstado.Location = new System.Drawing.Point(20, 17);
            this.groupBoxEstado.Name = "groupBoxEstado";
            this.groupBoxEstado.Size = new System.Drawing.Size(243, 73);
            this.groupBoxEstado.TabIndex = 4;
            this.groupBoxEstado.TabStop = false;
            this.groupBoxEstado.Text = "Estado";
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(25, 54);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(43, 13);
            this.labelMorada.TabIndex = 3;
            this.labelMorada.Text = "Morada";
            // 
            // labelNomeClienteValor
            // 
            this.labelNomeClienteValor.AutoSize = true;
            this.labelNomeClienteValor.Location = new System.Drawing.Point(109, 30);
            this.labelNomeClienteValor.Name = "labelNomeClienteValor";
            this.labelNomeClienteValor.Size = new System.Drawing.Size(92, 13);
            this.labelNomeClienteValor.TabIndex = 4;
            this.labelNomeClienteValor.Text = "{Nome do cliente}";
            // 
            // labelMoradaValor
            // 
            this.labelMoradaValor.AutoSize = true;
            this.labelMoradaValor.Location = new System.Drawing.Point(109, 54);
            this.labelMoradaValor.Name = "labelMoradaValor";
            this.labelMoradaValor.Size = new System.Drawing.Size(100, 13);
            this.labelMoradaValor.TabIndex = 5;
            this.labelMoradaValor.Text = "{Morada do cliente}";
            // 
            // labelEstadoAtual
            // 
            this.labelEstadoAtual.AutoSize = true;
            this.labelEstadoAtual.Location = new System.Drawing.Point(11, 30);
            this.labelEstadoAtual.Name = "labelEstadoAtual";
            this.labelEstadoAtual.Size = new System.Drawing.Size(66, 13);
            this.labelEstadoAtual.TabIndex = 4;
            this.labelEstadoAtual.Text = "Estado atual";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(633, 72);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(45, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "TOTAL:";
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValor.Location = new System.Drawing.Point(610, 98);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(106, 25);
            this.labelTotalValor.TabIndex = 7;
            this.labelTotalValor.Text = "{TOTAL}€";
            this.labelTotalValor.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBoxEstadoAtual
            // 
            this.comboBoxEstadoAtual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxEstadoAtual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEstadoAtual.DisplayMember = "0";
            this.comboBoxEstadoAtual.FormattingEnabled = true;
            this.comboBoxEstadoAtual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxEstadoAtual.Items.AddRange(new object[] {
            "Todos",
            "Terminados",
            "Cancelados",
            "Em curso"});
            this.comboBoxEstadoAtual.Location = new System.Drawing.Point(83, 27);
            this.comboBoxEstadoAtual.Name = "comboBoxEstadoAtual";
            this.comboBoxEstadoAtual.Size = new System.Drawing.Size(144, 21);
            this.comboBoxEstadoAtual.TabIndex = 3;
            // 
            // groupBoxAdcMenusPedidos
            // 
            this.groupBoxAdcMenusPedidos.Controls.Add(this.listBoxAdcMetodoPagamento);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.labelAdcTotalValor);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.labelAdcTotal);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.labelAdcMetodoPagamento);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.buttonAdcRemoverMenu);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.listBoxMenusPedidos);
            this.groupBoxAdcMenusPedidos.Location = new System.Drawing.Point(269, 161);
            this.groupBoxAdcMenusPedidos.Name = "groupBoxAdcMenusPedidos";
            this.groupBoxAdcMenusPedidos.Size = new System.Drawing.Size(743, 391);
            this.groupBoxAdcMenusPedidos.TabIndex = 8;
            this.groupBoxAdcMenusPedidos.TabStop = false;
            this.groupBoxAdcMenusPedidos.Text = "Lista Menus pedidos";
            // 
            // listBoxMenusPedidos
            // 
            this.listBoxMenusPedidos.FormattingEnabled = true;
            this.listBoxMenusPedidos.Location = new System.Drawing.Point(16, 29);
            this.listBoxMenusPedidos.Name = "listBoxMenusPedidos";
            this.listBoxMenusPedidos.Size = new System.Drawing.Size(560, 316);
            this.listBoxMenusPedidos.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelAdcContribuinteCliente);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBoxAdcCliente);
            this.groupBox3.Controls.Add(this.labelAdcMoradaCliente);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(269, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 119);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecionar Cliente";
            // 
            // labelAdcMoradaCliente
            // 
            this.labelAdcMoradaCliente.AutoSize = true;
            this.labelAdcMoradaCliente.Location = new System.Drawing.Point(108, 57);
            this.labelAdcMoradaCliente.Name = "labelAdcMoradaCliente";
            this.labelAdcMoradaCliente.Size = new System.Drawing.Size(100, 13);
            this.labelAdcMoradaCliente.TabIndex = 5;
            this.labelAdcMoradaCliente.Text = "{Morada do cliente}";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Morada:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nome:";
            // 
            // groupBoxAdicionarMenu
            // 
            this.groupBoxAdicionarMenu.Controls.Add(this.label2);
            this.groupBoxAdicionarMenu.Controls.Add(this.label4);
            this.groupBoxAdicionarMenu.Controls.Add(this.textBoxQuantidadeMenu);
            this.groupBoxAdicionarMenu.Controls.Add(this.labelDesignacaoProduto);
            this.groupBoxAdicionarMenu.Controls.Add(this.comboBoxAdicionarMenu);
            this.groupBoxAdicionarMenu.Controls.Add(this.labelQuantidadeProduto);
            this.groupBoxAdicionarMenu.Location = new System.Drawing.Point(17, 163);
            this.groupBoxAdicionarMenu.Name = "groupBoxAdicionarMenu";
            this.groupBoxAdicionarMenu.Size = new System.Drawing.Size(246, 177);
            this.groupBoxAdicionarMenu.TabIndex = 8;
            this.groupBoxAdicionarMenu.TabStop = false;
            this.groupBoxAdicionarMenu.Text = "Adicionar Menu";
            // 
            // labelDesignacaoProduto
            // 
            this.labelDesignacaoProduto.AutoSize = true;
            this.labelDesignacaoProduto.Location = new System.Drawing.Point(15, 22);
            this.labelDesignacaoProduto.Name = "labelDesignacaoProduto";
            this.labelDesignacaoProduto.Size = new System.Drawing.Size(35, 13);
            this.labelDesignacaoProduto.TabIndex = 4;
            this.labelDesignacaoProduto.Text = "Nome";
            // 
            // comboBoxAdicionarMenu
            // 
            this.comboBoxAdicionarMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAdicionarMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAdicionarMenu.DisplayMember = "0";
            this.comboBoxAdicionarMenu.FormattingEnabled = true;
            this.comboBoxAdicionarMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxAdicionarMenu.Items.AddRange(new object[] {
            "Todos",
            "Terminados",
            "Cancelados",
            "Em curso"});
            this.comboBoxAdicionarMenu.Location = new System.Drawing.Point(89, 19);
            this.comboBoxAdicionarMenu.Name = "comboBoxAdicionarMenu";
            this.comboBoxAdicionarMenu.Size = new System.Drawing.Size(151, 21);
            this.comboBoxAdicionarMenu.TabIndex = 3;
            // 
            // labelQuantidadeProduto
            // 
            this.labelQuantidadeProduto.AutoSize = true;
            this.labelQuantidadeProduto.Location = new System.Drawing.Point(15, 57);
            this.labelQuantidadeProduto.Name = "labelQuantidadeProduto";
            this.labelQuantidadeProduto.Size = new System.Drawing.Size(62, 13);
            this.labelQuantidadeProduto.TabIndex = 2;
            this.labelQuantidadeProduto.Text = "Quantidade";
            // 
            // buttonAdcRemoverMenu
            // 
            this.buttonAdcRemoverMenu.Location = new System.Drawing.Point(501, 351);
            this.buttonAdcRemoverMenu.Name = "buttonAdcRemoverMenu";
            this.buttonAdcRemoverMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonAdcRemoverMenu.TabIndex = 10;
            this.buttonAdcRemoverMenu.Text = "Remover";
            this.buttonAdcRemoverMenu.UseVisualStyleBackColor = true;
            // 
            // comboBoxAdcCliente
            // 
            this.comboBoxAdcCliente.FormattingEnabled = true;
            this.comboBoxAdcCliente.Location = new System.Drawing.Point(111, 22);
            this.comboBoxAdcCliente.Name = "comboBoxAdcCliente";
            this.comboBoxAdcCliente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdcCliente.TabIndex = 6;
            // 
            // labelAdcContribuinteCliente
            // 
            this.labelAdcContribuinteCliente.AutoSize = true;
            this.labelAdcContribuinteCliente.Location = new System.Drawing.Point(108, 82);
            this.labelAdcContribuinteCliente.Name = "labelAdcContribuinteCliente";
            this.labelAdcContribuinteCliente.Size = new System.Drawing.Size(120, 13);
            this.labelAdcContribuinteCliente.TabIndex = 8;
            this.labelAdcContribuinteCliente.Text = "{Contribuinte do cliente}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Contribuinte:";
            // 
            // textBoxQuantidadeMenu
            // 
            this.textBoxQuantidadeMenu.Location = new System.Drawing.Point(89, 54);
            this.textBoxQuantidadeMenu.Name = "textBoxQuantidadeMenu";
            this.textBoxQuantidadeMenu.Size = new System.Drawing.Size(151, 20);
            this.textBoxQuantidadeMenu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "{Contribuinte do cliente}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contribuinte:";
            // 
            // buttonRemoverMenu
            // 
            this.buttonRemoverMenu.Location = new System.Drawing.Point(501, 351);
            this.buttonRemoverMenu.Name = "buttonRemoverMenu";
            this.buttonRemoverMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverMenu.TabIndex = 17;
            this.buttonRemoverMenu.Text = "Remover";
            this.buttonRemoverMenu.UseVisualStyleBackColor = true;
            // 
            // labelMetodoPagamento
            // 
            this.labelMetodoPagamento.AutoSize = true;
            this.labelMetodoPagamento.Location = new System.Drawing.Point(602, 159);
            this.labelMetodoPagamento.Name = "labelMetodoPagamento";
            this.labelMetodoPagamento.Size = new System.Drawing.Size(118, 13);
            this.labelMetodoPagamento.TabIndex = 16;
            this.labelMetodoPagamento.Text = "Método de Pagamento:";
            // 
            // listBoxMetodoPagamento
            // 
            this.listBoxMetodoPagamento.Enabled = false;
            this.listBoxMetodoPagamento.FormattingEnabled = true;
            this.listBoxMetodoPagamento.Location = new System.Drawing.Point(601, 186);
            this.listBoxMetodoPagamento.Name = "listBoxMetodoPagamento";
            this.listBoxMetodoPagamento.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMetodoPagamento.Size = new System.Drawing.Size(115, 108);
            this.listBoxMetodoPagamento.TabIndex = 18;
            // 
            // listBoxAdcMetodoPagamento
            // 
            this.listBoxAdcMetodoPagamento.Enabled = false;
            this.listBoxAdcMetodoPagamento.FormattingEnabled = true;
            this.listBoxAdcMetodoPagamento.Location = new System.Drawing.Point(599, 189);
            this.listBoxAdcMetodoPagamento.Name = "listBoxAdcMetodoPagamento";
            this.listBoxAdcMetodoPagamento.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAdcMetodoPagamento.Size = new System.Drawing.Size(115, 108);
            this.listBoxAdcMetodoPagamento.TabIndex = 22;
            // 
            // labelAdcTotalValor
            // 
            this.labelAdcTotalValor.AutoSize = true;
            this.labelAdcTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdcTotalValor.Location = new System.Drawing.Point(608, 101);
            this.labelAdcTotalValor.Name = "labelAdcTotalValor";
            this.labelAdcTotalValor.Size = new System.Drawing.Size(106, 25);
            this.labelAdcTotalValor.TabIndex = 20;
            this.labelAdcTotalValor.Text = "{TOTAL}€";
            // 
            // labelAdcTotal
            // 
            this.labelAdcTotal.AutoSize = true;
            this.labelAdcTotal.Location = new System.Drawing.Point(631, 75);
            this.labelAdcTotal.Name = "labelAdcTotal";
            this.labelAdcTotal.Size = new System.Drawing.Size(45, 13);
            this.labelAdcTotal.TabIndex = 19;
            this.labelAdcTotal.Text = "TOTAL:";
            // 
            // labelAdcMetodoPagamento
            // 
            this.labelAdcMetodoPagamento.AutoSize = true;
            this.labelAdcMetodoPagamento.Location = new System.Drawing.Point(600, 162);
            this.labelAdcMetodoPagamento.Name = "labelAdcMetodoPagamento";
            this.labelAdcMetodoPagamento.Size = new System.Drawing.Size(118, 13);
            this.labelAdcMetodoPagamento.TabIndex = 21;
            this.labelAdcMetodoPagamento.Text = "Método de Pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "{SUB-TOTAL}€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sub-Total:";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 623);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdicionar.ResumeLayout(false);
            this.tabPageConsultar.ResumeLayout(false);
            this.groupBoxMenusPedidos.ResumeLayout(false);
            this.groupBoxMenusPedidos.PerformLayout();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxListaPedidos.ResumeLayout(false);
            this.groupBoxListaPedidos.PerformLayout();
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            this.groupBoxAdcMenusPedidos.ResumeLayout(false);
            this.groupBoxAdcMenusPedidos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxAdicionarMenu.ResumeLayout(false);
            this.groupBoxAdicionarMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdicionar;
        private System.Windows.Forms.TabPage tabPageConsultar;
        private System.Windows.Forms.GroupBox groupBoxMenusPedidos;
        private System.Windows.Forms.ListBox listBoxListaMenus;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBoxListaPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.ListBox listBoxPedidos;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.Label labelMoradaValor;
        private System.Windows.Forms.Label labelNomeClienteValor;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelEstadoAtual;
        private System.Windows.Forms.Label labelTotalValor;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxEstadoAtual;
        private System.Windows.Forms.GroupBox groupBoxAdicionarMenu;
        private System.Windows.Forms.Label labelDesignacaoProduto;
        private System.Windows.Forms.ComboBox comboBoxAdicionarMenu;
        private System.Windows.Forms.Label labelQuantidadeProduto;
        private System.Windows.Forms.GroupBox groupBoxAdcMenusPedidos;
        private System.Windows.Forms.Button buttonAdcRemoverMenu;
        private System.Windows.Forms.ListBox listBoxMenusPedidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelAdcMoradaCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxAdcCliente;
        private System.Windows.Forms.Label labelAdcContribuinteCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxQuantidadeMenu;
        private System.Windows.Forms.Button buttonRemoverMenu;
        private System.Windows.Forms.Label labelMetodoPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxMetodoPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAdcMetodoPagamento;
        private System.Windows.Forms.Label labelAdcTotalValor;
        private System.Windows.Forms.Label labelAdcTotal;
        private System.Windows.Forms.Label labelAdcMetodoPagamento;
    }
}