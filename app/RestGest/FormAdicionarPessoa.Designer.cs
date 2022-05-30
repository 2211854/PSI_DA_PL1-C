namespace RestGest
{
    partial class FormAdicionarPessoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.radioButtonTrabalhador = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.comboBoxMoradas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMoradas);
            this.groupBox1.Controls.Add(this.textBoxTelemovel);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonTrabalhador);
            this.groupBox1.Controls.Add(this.radioButtonCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Pessoa";
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Location = new System.Drawing.Point(25, 32);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(57, 17);
            this.radioButtonCliente.TabIndex = 0;
            this.radioButtonCliente.TabStop = true;
            this.radioButtonCliente.Text = "Cliente";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrabalhador
            // 
            this.radioButtonTrabalhador.AutoSize = true;
            this.radioButtonTrabalhador.Location = new System.Drawing.Point(126, 32);
            this.radioButtonTrabalhador.Name = "radioButtonTrabalhador";
            this.radioButtonTrabalhador.Size = new System.Drawing.Size(82, 17);
            this.radioButtonTrabalhador.TabIndex = 1;
            this.radioButtonTrabalhador.TabStop = true;
            this.radioButtonTrabalhador.Text = "Trabalhador";
            this.radioButtonTrabalhador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telemovel:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(28, 80);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(28, 119);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelemovel.TabIndex = 6;
            // 
            // comboBoxMoradas
            // 
            this.comboBoxMoradas.FormattingEnabled = true;
            this.comboBoxMoradas.Location = new System.Drawing.Point(263, 78);
            this.comboBoxMoradas.Name = "comboBoxMoradas";
            this.comboBoxMoradas.Size = new System.Drawing.Size(149, 21);
            this.comboBoxMoradas.TabIndex = 7;
            // 
            // FormAdicionarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdicionarPessoa";
            this.Text = "FormAdicionarPessoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMoradas;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTrabalhador;
        private System.Windows.Forms.RadioButton radioButtonCliente;
    }
}