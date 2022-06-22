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
            this.buttonAdicionarPedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTrabalhador = new System.Windows.Forms.ComboBox();
            this.labelPosicaoTrabalhador = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelContribuinteCliente = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageConsultar = new System.Windows.Forms.TabPage();
            this.buttonExportarPdf = new System.Windows.Forms.Button();
            this.buttonExportarTxt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxValorMetodoPagamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdicionarMetodoPagamento = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxMetodoPagamento = new System.Windows.Forms.ListBox();
            this.listBoxMetodoPagamentoUtilizado = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemoverMetodoPagamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.listBoxMenuRestaurante = new System.Windows.Forms.ListBox();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.labelEstadoAtual = new System.Windows.Forms.Label();
            this.comboBoxEstadoAtual = new System.Windows.Forms.ComboBox();
            this.groupBoxMenusPedidos = new System.Windows.Forms.GroupBox();
            this.buttonRemoverItem = new System.Windows.Forms.Button();
            this.listBoxItensPedidos = new System.Windows.Forms.ListBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.labelContribuinteClineteConsultar = new System.Windows.Forms.Label();
            this.labelMoradaClienteConsultar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNomeClienteConsultar = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxAdcMenusPedidos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageAdicionar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageConsultar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.groupBoxMenusPedidos.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxAdcMenusPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdicionar);
            this.tabControl1.Controls.Add(this.tabPageConsultar);
            this.tabControl1.Location = new System.Drawing.Point(332, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 599);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageAdicionar
            // 
            this.tabPageAdicionar.Controls.Add(this.buttonAdicionarPedido);
            this.tabPageAdicionar.Controls.Add(this.groupBox1);
            this.tabPageAdicionar.Controls.Add(this.groupBox3);
            this.tabPageAdicionar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdicionar.Name = "tabPageAdicionar";
            this.tabPageAdicionar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdicionar.Size = new System.Drawing.Size(786, 573);
            this.tabPageAdicionar.TabIndex = 0;
            this.tabPageAdicionar.Text = "Criar";
            this.tabPageAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarPedido
            // 
            this.buttonAdicionarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdicionarPedido.Location = new System.Drawing.Point(358, 394);
            this.buttonAdicionarPedido.Name = "buttonAdicionarPedido";
            this.buttonAdicionarPedido.Size = new System.Drawing.Size(93, 35);
            this.buttonAdicionarPedido.TabIndex = 22;
            this.buttonAdicionarPedido.Text = "Adicionar";
            this.buttonAdicionarPedido.UseVisualStyleBackColor = true;
            this.buttonAdicionarPedido.Click += new System.EventHandler(this.buttonAdicionarPedido_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTrabalhador);
            this.groupBox1.Controls.Add(this.labelPosicaoTrabalhador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(217, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Trabalhador";
            // 
            // comboBoxTrabalhador
            // 
            this.comboBoxTrabalhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxTrabalhador.FormattingEnabled = true;
            this.comboBoxTrabalhador.Location = new System.Drawing.Point(130, 37);
            this.comboBoxTrabalhador.Name = "comboBoxTrabalhador";
            this.comboBoxTrabalhador.Size = new System.Drawing.Size(174, 28);
            this.comboBoxTrabalhador.TabIndex = 6;
            this.comboBoxTrabalhador.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrabalhador_SelectedIndexChanged);
            // 
            // labelPosicaoTrabalhador
            // 
            this.labelPosicaoTrabalhador.AutoSize = true;
            this.labelPosicaoTrabalhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPosicaoTrabalhador.Location = new System.Drawing.Point(126, 72);
            this.labelPosicaoTrabalhador.Name = "labelPosicaoTrabalhador";
            this.labelPosicaoTrabalhador.Size = new System.Drawing.Size(182, 20);
            this.labelPosicaoTrabalhador.TabIndex = 5;
            this.labelPosicaoTrabalhador.Text = "{Posição do trabalhador}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(54, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Posição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(66, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelContribuinteCliente);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBoxCliente);
            this.groupBox3.Controls.Add(this.labelMoradaCliente);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(217, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 125);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecionar Cliente";
            // 
            // labelContribuinteCliente
            // 
            this.labelContribuinteCliente.AutoSize = true;
            this.labelContribuinteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelContribuinteCliente.Location = new System.Drawing.Point(126, 82);
            this.labelContribuinteCliente.Name = "labelContribuinteCliente";
            this.labelContribuinteCliente.Size = new System.Drawing.Size(177, 20);
            this.labelContribuinteCliente.TabIndex = 8;
            this.labelContribuinteCliente.Text = "{Contribuinte do cliente}";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(21, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Contribuinte:";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(129, 22);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(174, 28);
            this.comboBoxCliente.TabIndex = 6;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // labelMoradaCliente
            // 
            this.labelMoradaCliente.AutoSize = true;
            this.labelMoradaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMoradaCliente.Location = new System.Drawing.Point(125, 57);
            this.labelMoradaCliente.Name = "labelMoradaCliente";
            this.labelMoradaCliente.Size = new System.Drawing.Size(145, 20);
            this.labelMoradaCliente.TabIndex = 5;
            this.labelMoradaCliente.Text = "{Morada do cliente}";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(53, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Morada:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(65, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nome:";
            // 
            // tabPageConsultar
            // 
            this.tabPageConsultar.Controls.Add(this.buttonExportarPdf);
            this.tabPageConsultar.Controls.Add(this.buttonExportarTxt);
            this.tabPageConsultar.Controls.Add(this.groupBox4);
            this.tabPageConsultar.Controls.Add(this.groupBox2);
            this.tabPageConsultar.Controls.Add(this.groupBoxEstado);
            this.tabPageConsultar.Controls.Add(this.groupBoxMenusPedidos);
            this.tabPageConsultar.Controls.Add(this.groupBoxCliente);
            this.tabPageConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultar.Name = "tabPageConsultar";
            this.tabPageConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultar.Size = new System.Drawing.Size(786, 573);
            this.tabPageConsultar.TabIndex = 1;
            this.tabPageConsultar.Text = "Consultar";
            this.tabPageConsultar.UseVisualStyleBackColor = true;
            // 
            // buttonExportarPdf
            // 
            this.buttonExportarPdf.BackgroundImage = global::RestGest.Properties.Resources.pdfdownload;
            this.buttonExportarPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExportarPdf.Location = new System.Drawing.Point(735, 529);
            this.buttonExportarPdf.Name = "buttonExportarPdf";
            this.buttonExportarPdf.Size = new System.Drawing.Size(37, 33);
            this.buttonExportarPdf.TabIndex = 20;
            this.buttonExportarPdf.UseVisualStyleBackColor = true;
            this.buttonExportarPdf.Click += new System.EventHandler(this.buttonExportarPdf_Click);
            // 
            // buttonExportarTxt
            // 
            this.buttonExportarTxt.BackgroundImage = global::RestGest.Properties.Resources.txtdownload;
            this.buttonExportarTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExportarTxt.Location = new System.Drawing.Point(688, 529);
            this.buttonExportarTxt.Name = "buttonExportarTxt";
            this.buttonExportarTxt.Size = new System.Drawing.Size(37, 33);
            this.buttonExportarTxt.TabIndex = 19;
            this.buttonExportarTxt.UseVisualStyleBackColor = true;
            this.buttonExportarTxt.Click += new System.EventHandler(this.buttonExportarTxt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxValorMetodoPagamento);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.buttonAdicionarMetodoPagamento);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.listBoxMetodoPagamento);
            this.groupBox4.Controls.Add(this.listBoxMetodoPagamentoUtilizado);
            this.groupBox4.Controls.Add(this.labelTotal);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonRemoverMetodoPagamento);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(522, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 491);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Itens do pedido";
            // 
            // textBoxValorMetodoPagamento
            // 
            this.textBoxValorMetodoPagamento.Location = new System.Drawing.Point(72, 181);
            this.textBoxValorMetodoPagamento.Name = "textBoxValorMetodoPagamento";
            this.textBoxValorMetodoPagamento.Size = new System.Drawing.Size(140, 20);
            this.textBoxValorMetodoPagamento.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Valor:";
            // 
            // buttonAdicionarMetodoPagamento
            // 
            this.buttonAdicionarMetodoPagamento.Location = new System.Drawing.Point(78, 207);
            this.buttonAdicionarMetodoPagamento.Name = "buttonAdicionarMetodoPagamento";
            this.buttonAdicionarMetodoPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarMetodoPagamento.TabIndex = 21;
            this.buttonAdicionarMetodoPagamento.Text = "Adicionar";
            this.buttonAdicionarMetodoPagamento.UseVisualStyleBackColor = true;
            this.buttonAdicionarMetodoPagamento.Click += new System.EventHandler(this.buttonAdicionarMetodoPagamento_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Método de pagamento disponiveis:";
            // 
            // listBoxMetodoPagamento
            // 
            this.listBoxMetodoPagamento.FormattingEnabled = true;
            this.listBoxMetodoPagamento.Location = new System.Drawing.Point(19, 54);
            this.listBoxMetodoPagamento.Name = "listBoxMetodoPagamento";
            this.listBoxMetodoPagamento.Size = new System.Drawing.Size(213, 121);
            this.listBoxMetodoPagamento.TabIndex = 19;
            // 
            // listBoxMetodoPagamentoUtilizado
            // 
            this.listBoxMetodoPagamentoUtilizado.FormattingEnabled = true;
            this.listBoxMetodoPagamentoUtilizado.Location = new System.Drawing.Point(19, 269);
            this.listBoxMetodoPagamentoUtilizado.Name = "listBoxMetodoPagamentoUtilizado";
            this.listBoxMetodoPagamentoUtilizado.Size = new System.Drawing.Size(213, 108);
            this.listBoxMetodoPagamentoUtilizado.TabIndex = 18;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(77, 441);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(106, 25);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "{TOTAL}€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "TOTAL:";
            // 
            // buttonRemoverMetodoPagamento
            // 
            this.buttonRemoverMetodoPagamento.Location = new System.Drawing.Point(86, 383);
            this.buttonRemoverMetodoPagamento.Name = "buttonRemoverMetodoPagamento";
            this.buttonRemoverMetodoPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverMetodoPagamento.TabIndex = 17;
            this.buttonRemoverMetodoPagamento.Text = "Remover";
            this.buttonRemoverMetodoPagamento.UseVisualStyleBackColor = true;
            this.buttonRemoverMetodoPagamento.Click += new System.EventHandler(this.buttonRemoverMetodoPagamento_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Método de pagamento utilizados:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAdicionarItem);
            this.groupBox2.Controls.Add(this.listBoxMenuRestaurante);
            this.groupBox2.Location = new System.Drawing.Point(20, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 412);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu do restaurante";
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.Location = new System.Drawing.Point(83, 380);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarItem.TabIndex = 18;
            this.buttonAdicionarItem.Text = "Adicionar";
            this.buttonAdicionarItem.UseVisualStyleBackColor = true;
            this.buttonAdicionarItem.Click += new System.EventHandler(this.buttonAdicionarItem_Click);
            // 
            // listBoxMenuRestaurante
            // 
            this.listBoxMenuRestaurante.FormattingEnabled = true;
            this.listBoxMenuRestaurante.Location = new System.Drawing.Point(15, 19);
            this.listBoxMenuRestaurante.Name = "listBoxMenuRestaurante";
            this.listBoxMenuRestaurante.Size = new System.Drawing.Size(212, 355);
            this.listBoxMenuRestaurante.TabIndex = 1;
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
            // labelEstadoAtual
            // 
            this.labelEstadoAtual.AutoSize = true;
            this.labelEstadoAtual.Location = new System.Drawing.Point(11, 30);
            this.labelEstadoAtual.Name = "labelEstadoAtual";
            this.labelEstadoAtual.Size = new System.Drawing.Size(66, 13);
            this.labelEstadoAtual.TabIndex = 4;
            this.labelEstadoAtual.Text = "Estado atual";
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
            this.comboBoxEstadoAtual.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoAtual_SelectedIndexChanged);
            // 
            // groupBoxMenusPedidos
            // 
            this.groupBoxMenusPedidos.Controls.Add(this.buttonRemoverItem);
            this.groupBoxMenusPedidos.Controls.Add(this.listBoxItensPedidos);
            this.groupBoxMenusPedidos.Location = new System.Drawing.Point(269, 145);
            this.groupBoxMenusPedidos.Name = "groupBoxMenusPedidos";
            this.groupBoxMenusPedidos.Size = new System.Drawing.Size(247, 363);
            this.groupBoxMenusPedidos.TabIndex = 4;
            this.groupBoxMenusPedidos.TabStop = false;
            this.groupBoxMenusPedidos.Text = "Itens do pedido";
            // 
            // buttonRemoverItem
            // 
            this.buttonRemoverItem.Location = new System.Drawing.Point(77, 331);
            this.buttonRemoverItem.Name = "buttonRemoverItem";
            this.buttonRemoverItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverItem.TabIndex = 17;
            this.buttonRemoverItem.Text = "Remover";
            this.buttonRemoverItem.UseVisualStyleBackColor = true;
            this.buttonRemoverItem.Click += new System.EventHandler(this.buttonRemoverItem_Click);
            // 
            // listBoxItensPedidos
            // 
            this.listBoxItensPedidos.FormattingEnabled = true;
            this.listBoxItensPedidos.Location = new System.Drawing.Point(16, 16);
            this.listBoxItensPedidos.Name = "listBoxItensPedidos";
            this.listBoxItensPedidos.Size = new System.Drawing.Size(213, 303);
            this.listBoxItensPedidos.TabIndex = 1;
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.labelContribuinteClineteConsultar);
            this.groupBoxCliente.Controls.Add(this.labelMoradaClienteConsultar);
            this.groupBoxCliente.Controls.Add(this.label8);
            this.groupBoxCliente.Controls.Add(this.labelNomeClienteConsultar);
            this.groupBoxCliente.Controls.Add(this.labelMorada);
            this.groupBoxCliente.Controls.Add(this.labelNome);
            this.groupBoxCliente.Location = new System.Drawing.Point(269, 17);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(247, 122);
            this.groupBoxCliente.TabIndex = 3;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // labelContribuinteClineteConsultar
            // 
            this.labelContribuinteClineteConsultar.AutoSize = true;
            this.labelContribuinteClineteConsultar.Location = new System.Drawing.Point(109, 79);
            this.labelContribuinteClineteConsultar.Name = "labelContribuinteClineteConsultar";
            this.labelContribuinteClineteConsultar.Size = new System.Drawing.Size(120, 13);
            this.labelContribuinteClineteConsultar.TabIndex = 14;
            this.labelContribuinteClineteConsultar.Text = "{Contribuinte do cliente}";
            // 
            // labelMoradaClienteConsultar
            // 
            this.labelMoradaClienteConsultar.AutoSize = true;
            this.labelMoradaClienteConsultar.Location = new System.Drawing.Point(109, 54);
            this.labelMoradaClienteConsultar.Name = "labelMoradaClienteConsultar";
            this.labelMoradaClienteConsultar.Size = new System.Drawing.Size(100, 13);
            this.labelMoradaClienteConsultar.TabIndex = 5;
            this.labelMoradaClienteConsultar.Text = "{Morada do cliente}";
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
            // labelNomeClienteConsultar
            // 
            this.labelNomeClienteConsultar.AutoSize = true;
            this.labelNomeClienteConsultar.Location = new System.Drawing.Point(109, 30);
            this.labelNomeClienteConsultar.Name = "labelNomeClienteConsultar";
            this.labelNomeClienteConsultar.Size = new System.Drawing.Size(92, 13);
            this.labelNomeClienteConsultar.TabIndex = 4;
            this.labelNomeClienteConsultar.Text = "{Nome do cliente}";
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
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(25, 30);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // groupBoxAdcMenusPedidos
            // 
            this.groupBoxAdcMenusPedidos.Controls.Add(this.label1);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.listBoxPedidos);
            this.groupBoxAdcMenusPedidos.Controls.Add(this.comboBoxFiltro);
            this.groupBoxAdcMenusPedidos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdcMenusPedidos.Name = "groupBoxAdcMenusPedidos";
            this.groupBoxAdcMenusPedidos.Size = new System.Drawing.Size(314, 595);
            this.groupBoxAdcMenusPedidos.TabIndex = 8;
            this.groupBoxAdcMenusPedidos.TabStop = false;
            this.groupBoxAdcMenusPedidos.Text = "Lista de Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro:";
            // 
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(16, 68);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(284, 511);
            this.listBoxPedidos.TabIndex = 1;
            this.listBoxPedidos.SelectedIndexChanged += new System.EventHandler(this.listBoxPedidos_SelectedIndexChanged);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxFiltro.DisplayMember = "0";
            this.comboBoxFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todos",
            "Terminados",
            "Cancelados",
            "Em curso"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(91, 22);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(188, 28);
            this.comboBoxFiltro.TabIndex = 1;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 623);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxAdcMenusPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdicionar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageConsultar.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            this.groupBoxMenusPedidos.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxAdcMenusPedidos.ResumeLayout(false);
            this.groupBoxAdcMenusPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdicionar;
        private System.Windows.Forms.TabPage tabPageConsultar;
        private System.Windows.Forms.GroupBox groupBoxMenusPedidos;
        private System.Windows.Forms.ListBox listBoxItensPedidos;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.Label labelMoradaClienteConsultar;
        private System.Windows.Forms.Label labelNomeClienteConsultar;
        private System.Windows.Forms.Label labelMorada;
        private System.Windows.Forms.Label labelEstadoAtual;
        private System.Windows.Forms.ComboBox comboBoxEstadoAtual;
        private System.Windows.Forms.GroupBox groupBoxAdcMenusPedidos;
        private System.Windows.Forms.ListBox listBoxPedidos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelMoradaCliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelContribuinteCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonRemoverItem;
        private System.Windows.Forms.Label labelContribuinteClineteConsultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTrabalhador;
        private System.Windows.Forms.Label labelPosicaoTrabalhador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxMenuRestaurante;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxMetodoPagamentoUtilizado;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemoverMetodoPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxValorMetodoPagamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdicionarMetodoPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxMetodoPagamento;
        private System.Windows.Forms.Button buttonAdicionarItem;
        private System.Windows.Forms.Button buttonAdicionarPedido;
        private System.Windows.Forms.Button buttonExportarPdf;
        private System.Windows.Forms.Button buttonExportarTxt;
    }
}