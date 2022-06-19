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
                Cliente cliente = new Cliente(textBoxNome.Text,Int32.Parse(textBoxTelemovel.Text), Int32.Parse(textBoxNumContribuinte.Text));
                Morada clienteMorada = new Morada(textBoxRua.Text, textBoxCidade.Text, textBoxCodPostal.Text, textBoxPais.Text);
                clienteMorada.Pessoa = cliente;
                clienteMorada.Restaurante = null;


                meuRestaurante.PessoaSet.Add(cliente);
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
            listBoxClientes.DataSource = meuRestaurante.PessoaSet.ToList<Pessoa>();
        }

    }
}
