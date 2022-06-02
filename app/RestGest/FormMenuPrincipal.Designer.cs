namespace RestGest
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTrabalhador = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButtonSair = new System.Windows.Forms.ToolStripSplitButton();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.buttonMenus = new System.Windows.Forms.Button();
            this.buttonPedidos = new System.Windows.Forms.Button();
            this.buttonIndividualRestaurante = new System.Windows.Forms.Button();
            this.buttonGlobalRestaurantes = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTrabalhador,
            this.toolStripSplitButtonSair});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStripMain";
            // 
            // toolStripStatusLabelTrabalhador
            // 
            this.toolStripStatusLabelTrabalhador.Name = "toolStripStatusLabelTrabalhador";
            this.toolStripStatusLabelTrabalhador.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabelTrabalhador.Text = "Nome trabalhador";
            // 
            // toolStripSplitButtonSair
            // 
            this.toolStripSplitButtonSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonSair.Image = global::RestGest.Properties.Resources.sair;
            this.toolStripSplitButtonSair.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButtonSair.Name = "toolStripSplitButtonSair";
            this.toolStripSplitButtonSair.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButtonSair.Text = "toolStripSplitButtonSair";
            this.toolStripSplitButtonSair.ButtonClick += new System.EventHandler(this.toolStripSplitButtonSair_ButtonClick);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = global::RestGest.Properties.Resources.RestGestLogo256;
            this.pictureBoxBanner.Location = new System.Drawing.Point(50, 25);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 8;
            this.pictureBoxBanner.TabStop = false;
            // 
            // buttonMenus
            // 
            this.buttonMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenus.Image = global::RestGest.Properties.Resources.table_list_solid;
            this.buttonMenus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMenus.Location = new System.Drawing.Point(256, 437);
            this.buttonMenus.Name = "buttonMenus";
            this.buttonMenus.Size = new System.Drawing.Size(200, 200);
            this.buttonMenus.TabIndex = 6;
            this.buttonMenus.Text = "Menus";
            this.buttonMenus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenus.UseVisualStyleBackColor = true;
            // 
            // buttonPedidos
            // 
            this.buttonPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPedidos.Image = global::RestGest.Properties.Resources.receipt_solid;
            this.buttonPedidos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPedidos.Location = new System.Drawing.Point(256, 231);
            this.buttonPedidos.Name = "buttonPedidos";
            this.buttonPedidos.Size = new System.Drawing.Size(200, 200);
            this.buttonPedidos.TabIndex = 5;
            this.buttonPedidos.Text = "Pedidos";
            this.buttonPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPedidos.UseVisualStyleBackColor = true;
            // 
            // buttonIndividualRestaurante
            // 
            this.buttonIndividualRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndividualRestaurante.Image = global::RestGest.Properties.Resources.building_solid;
            this.buttonIndividualRestaurante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIndividualRestaurante.Location = new System.Drawing.Point(462, 231);
            this.buttonIndividualRestaurante.Name = "buttonIndividualRestaurante";
            this.buttonIndividualRestaurante.Size = new System.Drawing.Size(200, 200);
            this.buttonIndividualRestaurante.TabIndex = 3;
            this.buttonIndividualRestaurante.Text = "Individual Restaurante";
            this.buttonIndividualRestaurante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIndividualRestaurante.UseVisualStyleBackColor = true;
            // 
            // buttonGlobalRestaurantes
            // 
            this.buttonGlobalRestaurantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGlobalRestaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGlobalRestaurantes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGlobalRestaurantes.Image = global::RestGest.Properties.Resources.globe;
            this.buttonGlobalRestaurantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGlobalRestaurantes.Location = new System.Drawing.Point(50, 231);
            this.buttonGlobalRestaurantes.Name = "buttonGlobalRestaurantes";
            this.buttonGlobalRestaurantes.Size = new System.Drawing.Size(200, 200);
            this.buttonGlobalRestaurantes.TabIndex = 2;
            this.buttonGlobalRestaurantes.Text = "Global Restaurantes";
            this.buttonGlobalRestaurantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGlobalRestaurantes.UseVisualStyleBackColor = true;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.Image = global::RestGest.Properties.Resources.image_portrait_solid;
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClientes.Location = new System.Drawing.Point(256, 25);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(200, 200);
            this.buttonClientes.TabIndex = 1;
            this.buttonClientes.Text = " Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 646);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonMenus);
            this.Controls.Add(this.buttonPedidos);
            this.Controls.Add(this.buttonIndividualRestaurante);
            this.Controls.Add(this.buttonGlobalRestaurantes);
            this.Controls.Add(this.buttonClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuPrincipal";
            this.Text = "RestGest - Menu Principal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonGlobalRestaurantes;
        private System.Windows.Forms.Button buttonIndividualRestaurante;
        private System.Windows.Forms.Button buttonPedidos;
        private System.Windows.Forms.Button buttonMenus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTrabalhador;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSair;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
    }
}