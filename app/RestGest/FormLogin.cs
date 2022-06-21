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
    public partial class FormLogin : Form
    {
        public static meuRestauranteContainer meuRestaurante;

        public FormLogin()
        {
            InitializeComponent();
            FormMenu form = new FormMenu();
            form.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if(textBoxEmail.Text != "" && textBoxPassword.Text != "")
            {

                /*List<PessoaSet_Trabalhador> trabalhadores = meuRestaurante.PessoaSet_Cliente.OfType<PessoaSet_Trabalhador>().ToList();
                PessoaSet_Trabalhador selectResult = from t in trabalhadores
                                   select new { Email = textBoxEmail.Text, Password = textBoxPassword.Text };


                if ( selectResult!=null) 
                {
                    FormMenuPrincipal formPrincipal = new FormMenuPrincipal(selectResult);
                    formPrincipal.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Combinação email e password não corresponde a nenhum trabalhador válido.", "Falha no Inicio de Sessão", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }*/

            }
            else
            {
                MessageBox.Show("Os dados Passowrd e Email devem estar ambos preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
