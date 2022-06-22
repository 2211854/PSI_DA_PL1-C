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
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.buttonMenus = new System.Windows.Forms.Button();
            this.buttonIndividualRestaurante = new System.Windows.Forms.Button();
            this.buttonGlobalRestaurantes = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = global::RestGest.Properties.Resources.RestGestLogo256;
            this.pictureBoxBanner.Location = new System.Drawing.Point(256, 231);
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
            this.buttonMenus.Click += new System.EventHandler(this.buttonMenus_Click);
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
            this.buttonIndividualRestaurante.Click += new System.EventHandler(this.buttonIndividualRestaurante_Click);
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
            this.buttonGlobalRestaurantes.Click += new System.EventHandler(this.buttonGlobalRestaurantes_Click);
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
            this.Controls.Add(this.buttonMenus);
            this.Controls.Add(this.buttonIndividualRestaurante);
            this.Controls.Add(this.buttonGlobalRestaurantes);
            this.Controls.Add(this.buttonClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuPrincipal";
            this.Text = "RestGest - Menu Principal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonGlobalRestaurantes;
        private System.Windows.Forms.Button buttonIndividualRestaurante;
        private System.Windows.Forms.Button buttonMenus;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
    }
}