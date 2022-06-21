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
    public partial class FormIndividualRestaurante : Form
    {

        public static meuRestauranteContainer meuRestaurante;

        public FormIndividualRestaurante()
        {
            meuRestaurante = new meuRestauranteContainer();
            InitializeComponent();
            LerDadosRestaurantes();
        }

        private void FormIndividualRestaurante_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxAdcMenusPedidos_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestauranteSet restaurante = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
            labelNumeroTrabalhadores.Text = "Nº Trabalhadores: " + restaurante.GetNumeroTrabalhadores();
            labelNumeroPedidos.Text = "Nº Pedidos: " + restaurante.GetNumeroPedidos();
            labelTotalFaturado.Text = "Total Faturado: " + restaurante.GetTotalFaturado();
            labelTotalSalarios.Text = restaurante.GetTotalSalarios() + " €";
        }


        private void LerDadosRestaurantes()
        {
            comboBoxRestaurantes.DataSource = meuRestaurante.RestauranteSet.OfType<RestauranteSet>().ToList();
        }

        private void buttonAdicionarTrabalhador_Click(object sender, EventArgs e)
        {

            //nome salario posicao email password

            PessoaSet pessoa = new PessoaSet();
            pessoa.Nome = textBoxNomeTrabalhador.Text;
           /* pessoa.

            PessoaSet_Trabalhador trabalhador = new PessoaSet_Trabalhador();
            trabalhador.nome = textBoxNomePagamento.Text;
            metodoPagamento.Ativo = (comboBoxEstadoPagamento.Text == "Ativado") ? true : false;

            meuRestaurante.MetodoPagamentoSet.Add(metodoPagamento);
            meuRestaurante.SaveChanges();

            LerDadosMetodosPagamento();

            textBoxNomePagamento.Text = "";
            comboBoxEstadoPagamento.SelectedIndex = -1;*/
        }

        private void buttonEditarTrabalhador_Click(object sender, EventArgs e)
        {
        }
    }
}
