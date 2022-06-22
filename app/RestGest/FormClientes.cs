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
    public partial class FormClientes : Form
    {
        public static meuRestauranteContainer meuRestaurante;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            meuRestaurante = new meuRestauranteContainer();
            LerDadosCliente();
        }

        private void buttonAdicionarClientes_Click(object sender, EventArgs e)
        {
            if(textBoxNome.Text != "" && textBoxTelemovel.Text != "" && textBoxNumContribuinte.Text != "" && textBoxRua.Text != "" && textBoxCodPostal.Text != "" && textBoxCidade.Text != "" && textBoxPais.Text != "")
            {
                PessoaSet Pessoa = new PessoaSet();
                Pessoa.Nome = textBoxNome.Text;
                Pessoa.Telemovel = Int32.Parse(textBoxTelemovel.Text);
                Pessoa.Ativo = true;
                PessoaSet_Cliente cliente = new PessoaSet_Cliente();
                cliente.PessoaSet = Pessoa;
                cliente.NumContribuinte = Int32.Parse(textBoxNumContribuinte.Text);
                MoradaSet clienteMorada = new MoradaSet();
                clienteMorada.Rua = textBoxRua.Text;
                clienteMorada.Cidade = textBoxCidade.Text;
                clienteMorada.CodPostal = textBoxCodPostal.Text;
                clienteMorada.Pais = textBoxPais.Text;
                Pessoa.MoradaSet = clienteMorada;


                meuRestaurante.PessoaSet_Cliente.Add(cliente);
                meuRestaurante.MoradaSet.Add(clienteMorada);
                meuRestaurante.SaveChanges();
                LerDadosCliente();

                //Limpar as textBoxes
                textBoxNome.Text = "";
                textBoxTelemovel.Text = "";
                textBoxNumContribuinte.Text = "";
                textBoxRua.Text = "";
                textBoxCodPostal.Text = "";
                textBoxCidade.Text = "";
                textBoxPais.Text = "";
            }
            else
            {
                 MessageBox.Show("Preencha todos os dados solicitados!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            

        }


        private void LerDadosCliente()
        {
            listBoxClientes.DataSource = meuRestaurante.PessoaSet_Cliente.OfType<PessoaSet_Cliente>().ToList();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PessoaSet_Cliente cliente = (PessoaSet_Cliente)listBoxClientes.SelectedItem;
            textBoxNomeAlterar.Text = cliente.PessoaSet.Nome;
            textBoxTelemovelAlterar.Text = cliente.PessoaSet.Telemovel.ToString();
            textBoxNumContribuinteAlterar.Text = cliente.NumContribuinte.ToString();
            textBoxRuaAlterar.Text = cliente.PessoaSet.MoradaSet.Rua;
            textBoxCodPostalAlterar.Text = cliente.PessoaSet.MoradaSet.CodPostal;
            textBoxCidadeAlterar.Text = cliente.PessoaSet.MoradaSet.Cidade;
            textBoxPaisAlterar.Text = cliente.PessoaSet.MoradaSet.Pais;
            comboBoxEstadoAlterar.SelectedIndex = cliente.PessoaSet.Ativo ? 0 : 1;

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
                if (textBoxNomeAlterar.Text != "" && textBoxTelemovelAlterar.Text != "" && textBoxNumContribuinteAlterar.Text != "" && textBoxRuaAlterar.Text != "" && textBoxCodPostalAlterar.Text != "" && textBoxCidadeAlterar.Text != "" && textBoxPaisAlterar.Text != "" && listBoxClientes.SelectedItem != null && comboBoxEstadoAlterar.SelectedIndex >= 0)
                {
                    PessoaSet_Cliente cliente = (PessoaSet_Cliente)listBoxClientes.SelectedItem;
                    cliente.PessoaSet.Nome = textBoxNomeAlterar.Text;
                    cliente.PessoaSet.Telemovel = Int32.Parse(textBoxTelemovelAlterar.Text);
                    cliente.NumContribuinte = Int32.Parse(textBoxNumContribuinteAlterar.Text);
                    cliente.PessoaSet.MoradaSet.Rua = textBoxRuaAlterar.Text;
                    cliente.PessoaSet.MoradaSet.CodPostal = textBoxCodPostalAlterar.Text;
                    cliente.PessoaSet.MoradaSet.Cidade = textBoxCidadeAlterar.Text;
                    cliente.PessoaSet.MoradaSet.Pais = textBoxPaisAlterar.Text;
                    cliente.PessoaSet.Ativo = (comboBoxEstadoAlterar.Text == "Ativado") ? true : false;


                    meuRestaurante.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Preencha e selecione todos os dados solicitados para proceder a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

        }

        private void textBoxTelemovel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumContribuinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelemovelAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumContribuinteAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodPostalAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
