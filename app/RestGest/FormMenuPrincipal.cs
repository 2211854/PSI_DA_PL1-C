using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormMenuPrincipal : Form
    {


        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void toolStripSplitButtonSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClientes_click(object sender, EventArgs e)
        {
           FormClientes form = new FormClientes();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonGlobalRestaurantes_Click(object sender, EventArgs e)
        {
            FormGlobalRestaurantes form = new FormGlobalRestaurantes();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonMenus_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonIndividualRestaurante_Click(object sender, EventArgs e)
        {

            FormIndividualRestaurante form = new FormIndividualRestaurante();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
