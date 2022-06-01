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
            this.listBoxPedidos = new System.Windows.Forms.ListBox();
            this.groupBoxListaPedidos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.groupBoxListaPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPedidos
            // 
            this.listBoxPedidos.FormattingEnabled = true;
            this.listBoxPedidos.Location = new System.Drawing.Point(28, 79);
            this.listBoxPedidos.Name = "listBoxPedidos";
            this.listBoxPedidos.Size = new System.Drawing.Size(206, 446);
            this.listBoxPedidos.TabIndex = 0;
            // 
            // groupBoxListaPedidos
            // 
            this.groupBoxListaPedidos.Controls.Add(this.label1);
            this.groupBoxListaPedidos.Controls.Add(this.comboBoxFiltro);
            this.groupBoxListaPedidos.Controls.Add(this.listBoxPedidos);
            this.groupBoxListaPedidos.Location = new System.Drawing.Point(30, 37);
            this.groupBoxListaPedidos.Name = "groupBoxListaPedidos";
            this.groupBoxListaPedidos.Size = new System.Drawing.Size(253, 540);
            this.groupBoxListaPedidos.TabIndex = 1;
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
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 1;
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 623);
            this.Controls.Add(this.groupBoxListaPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.groupBoxListaPedidos.ResumeLayout(false);
            this.groupBoxListaPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPedidos;
        private System.Windows.Forms.GroupBox groupBoxListaPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
    }
}