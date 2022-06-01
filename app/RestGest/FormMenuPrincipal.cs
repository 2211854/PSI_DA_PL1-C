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

        Trabalhador Funcionario;

        public FormMenuPrincipal(Trabalhador funcionario)
        {
            InitializeComponent();
            Funcionario = funcionario;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
                toolStripStatusLabelTrabalhador.Text = Funcionario.Nome;
        }

        private void toolStripSplitButtonSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClientes_click(object sender, EventArgs e)
        {

        }
    }
}
