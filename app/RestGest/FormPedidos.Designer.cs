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
            this.groupBoxAdcMenusPedidos = new System.Windows.Forms.GroupBox();
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelContribuinteCliente = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelMoradaCliente = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageConsultar = new System.Windows.Forms.TabPage();
            this.groupBoxEstado = new System.Windows.Forms.GroupBox();
            this.labelEstadoAtual = new System.Windows.Forms.Label();
            this.comboBoxEstadoAtual = new System.Windows.Forms.ComboBox();
            this.groupBoxMenusPedidos = new System.Windows.Forms.GroupBox();
            this.buttonRemoverItem = new System.Windows.Forms.Button();
            this.listBoxItensPedidos = new System.Windows.Forms.ListBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMoradaValor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNomeClienteValor = new System.Windows.Forms.Label();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTrabalhador = new System.Windows.Forms.ComboBox();
            this.labelPosicaoTrabalhador = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxMenuRestaurante = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxMetodoPagamentoUtilizado = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemoverMetodoPagamento = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxMetodoPagamento = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdicionarMetodoPagamento = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxValorMetodoPagamento = new System.Windows.Forms.TextBox();
            this.buttonAdicionarItem = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageAdicionar.SuspendLayout();
            this.groupBoxAdcMenusPedidos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageConsultar.SuspendLayout();
            this.groupBoxEstado.SuspendLayout();
            this.groupBoxMenusPedidos.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(16, 68);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(284, 511);
            this.listBoxPedidos.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelContribuinteCliente);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBoxCliente);
            this.groupBox3.Controls.Add(this.labelMoradaCliente);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
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
            this.tabPageConsultar.Controls.Add(this.buttonAlterar);
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
            this.tabPageConsultar.Click += new System.EventHandler(this.tabPageConsultar_Click);
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
            this.groupBoxMenusPedidos.Enter += new System.EventHandler(this.groupBoxMenusPedidos_Enter);
            // 
            // buttonRemoverItem
            // 
            this.buttonRemoverItem.Location = new System.Drawing.Point(77, 325);
            this.buttonRemoverItem.Name = "buttonRemoverItem";
            this.buttonRemoverItem.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverItem.TabIndex = 17;
            this.buttonRemoverItem.Text = "Remover";
            this.buttonRemoverItem.UseVisualStyleBackColor = true;
            // 
            // listBoxItensPedidos
            // 
            this.listBoxItensPedidos.FormattingEnabled = true;
            this.listBoxItensPedidos.Location = new System.Drawing.Point(16, 29);
            this.listBoxItensPedidos.Name = "listBoxItensPedidos";
            this.listBoxItensPedidos.Size = new System.Drawing.Size(213, 290);
            this.listBoxItensPedidos.TabIndex = 1;
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
            this.groupBoxCliente.Size = new System.Drawing.Size(247, 122);
            this.groupBoxCliente.TabIndex = 3;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
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
            // labelMoradaValor
            // 
            this.labelMoradaValor.AutoSize = true;
            this.labelMoradaValor.Location = new System.Drawing.Point(109, 54);
            this.labelMoradaValor.Name = "labelMoradaValor";
            this.labelMoradaValor.Size = new System.Drawing.Size(100, 13);
            this.labelMoradaValor.TabIndex = 5;
            this.labelMoradaValor.Text = "{Morada do cliente}";
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
            // labelNomeClienteValor
            // 
            this.labelNomeClienteValor.AutoSize = true;
            this.labelNomeClienteValor.Location = new System.Drawing.Point(109, 30);
            this.labelNomeClienteValor.Name = "labelNomeClienteValor";
            this.labelNomeClienteValor.Size = new System.Drawing.Size(92, 13);
            this.labelNomeClienteValor.TabIndex = 4;
            this.labelNomeClienteValor.Text = "{Nome do cliente}";
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
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(25, 30);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCliente.TabIndex = 2;
            this.labelNomeCliente.Text = "Nome";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTrabalhador);
            this.groupBox1.Controls.Add(this.labelPosicaoTrabalhador);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 159);
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
            // listBoxMenuRestaurante
            // 
            this.listBoxMenuRestaurante.FormattingEnabled = true;
            this.listBoxMenuRestaurante.Location = new System.Drawing.Point(15, 19);
            this.listBoxMenuRestaurante.Name = "listBoxMenuRestaurante";
            this.listBoxMenuRestaurante.Size = new System.Drawing.Size(212, 342);
            this.listBoxMenuRestaurante.TabIndex = 1;
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
            // listBoxMetodoPagamentoUtilizado
            // 
            this.listBoxMetodoPagamentoUtilizado.Enabled = false;
            this.listBoxMetodoPagamentoUtilizado.FormattingEnabled = true;
            this.listBoxMetodoPagamentoUtilizado.Location = new System.Drawing.Point(19, 269);
            this.listBoxMetodoPagamentoUtilizado.Name = "listBoxMetodoPagamentoUtilizado";
            this.listBoxMetodoPagamentoUtilizado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
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
            // listBoxMetodoPagamento
            // 
            this.listBoxMetodoPagamento.FormattingEnabled = true;
            this.listBoxMetodoPagamento.Location = new System.Drawing.Point(19, 54);
            this.listBoxMetodoPagamento.Name = "listBoxMetodoPagamento";
            this.listBoxMetodoPagamento.Size = new System.Drawing.Size(213, 121);
            this.listBoxMetodoPagamento.TabIndex = 19;
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
            // buttonAdicionarMetodoPagamento
            // 
            this.buttonAdicionarMetodoPagamento.Location = new System.Drawing.Point(78, 207);
            this.buttonAdicionarMetodoPagamento.Name = "buttonAdicionarMetodoPagamento";
            this.buttonAdicionarMetodoPagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarMetodoPagamento.TabIndex = 21;
            this.buttonAdicionarMetodoPagamento.Text = "Remover";
            this.buttonAdicionarMetodoPagamento.UseVisualStyleBackColor = true;
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
            // textBoxValorMetodoPagamento
            // 
            this.textBoxValorMetodoPagamento.Location = new System.Drawing.Point(72, 181);
            this.textBoxValorMetodoPagamento.Name = "textBoxValorMetodoPagamento";
            this.textBoxValorMetodoPagamento.Size = new System.Drawing.Size(140, 20);
            this.textBoxValorMetodoPagamento.TabIndex = 23;
            // 
            // buttonAdicionarItem
            // 
            this.buttonAdicionarItem.Location = new System.Drawing.Point(83, 380);
            this.buttonAdicionarItem.Name = "buttonAdicionarItem";
            this.buttonAdicionarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarItem.TabIndex = 18;
            this.buttonAdicionarItem.Text = "Adicionar";
            this.buttonAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(346, 534);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 18;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
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
            this.groupBoxAdcMenusPedidos.ResumeLayout(false);
            this.groupBoxAdcMenusPedidos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageConsultar.ResumeLayout(false);
            this.groupBoxEstado.ResumeLayout(false);
            this.groupBoxEstado.PerformLayout();
            this.groupBoxMenusPedidos.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdicionar;
        private System.Windows.Forms.TabPage tabPageConsultar;
        private System.Windows.Forms.GroupBox groupBoxMenusPedidos;
        private System.Windows.Forms.ListBox listBoxItensPedidos;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.GroupBox groupBoxEstado;
        private System.Windows.Forms.Label labelMoradaValor;
        private System.Windows.Forms.Label labelNomeClienteValor;
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
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionarItem;
    }
}