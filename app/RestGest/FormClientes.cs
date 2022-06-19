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
        }

        private void buttonAdicionarClientes_Click(object sender, EventArgs e)
        {
            if(textBoxNome.Text != "" && textBoxTelemovel.Text != "" && textBoxNumContribuinte.Text != "" && textBoxRua.Text != "" && textBoxCodPostal.Text != "" && textBoxCidade.Text != "" && textBoxPais.Text != "")
            {
                PessoaSet Pessoa = new PessoaSet();
                Pessoa.Nome = textBoxNome.Text;
                Pessoa.Telemovel = Int32.Parse(textBoxTelemovel.Text);
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

    }
}
