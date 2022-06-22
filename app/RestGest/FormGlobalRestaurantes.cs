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
    public partial class FormGlobalRestaurantes : Form
    {
        public static meuRestauranteContainer meuRestaurante;

        public FormGlobalRestaurantes()
        {
            InitializeComponent();
        }

        //Global
        private void FormGlobalRestaurantes_Load(object sender, EventArgs e)
        {
            meuRestaurante = new meuRestauranteContainer();
            LerDadosRestaurantes();
            LerDadosMetodosPagamento(); 
            LerDadosCategorias();
        }

        //Restaurante
        private void buttonAdicionarRestaurantes_Click(object sender, EventArgs e)
        {
            if (textBoxNomeRestaurante.Text != "" && textBoxRuaRestaurante.Text != "" && textBoxCidadeRestaurante.Text != "" && textBoxCodPostalRestaurante.Text != "" && textBoxPaisRestaurante.Text != "")
            {
                MoradaSet restauranteMorada = new MoradaSet();
                restauranteMorada.Rua = textBoxRuaRestaurante.Text;
                restauranteMorada.Cidade = textBoxCidadeRestaurante.Text;
                restauranteMorada.CodPostal = textBoxCodPostalRestaurante.Text;
                restauranteMorada.Pais = textBoxPaisRestaurante.Text;
                RestauranteSet restaurante = new RestauranteSet();
                restaurante.Nome = textBoxNomeRestaurante.Text;
                restaurante.MoradaSet = restauranteMorada;

                meuRestaurante.RestauranteSet.Add(restaurante);
                meuRestaurante.MoradaSet.Add(restauranteMorada);
                meuRestaurante.SaveChanges();

                LerDadosRestaurantes();

                textBoxRuaRestaurante.Text = "";
                textBoxCidadeRestaurante.Text = "";
                textBoxCodPostalRestaurante.Text = "";
                textBoxPaisRestaurante.Text = "";
                textBoxNomeRestaurante.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonApagarRestaurantes_Click(object sender, EventArgs e)
        {
            RestauranteSet restaurante = (RestauranteSet)listBoxRestaurantes.SelectedItem;

            meuRestaurante.RestauranteSet.Remove(restaurante);
            meuRestaurante.SaveChanges();
            LerDadosRestaurantes();
        }

        private void buttonAlterarRestaurante_Click(object sender, EventArgs e)
        {
            if (textBoxNomeRestauranteAlterar.Text != "" && textBoxRuaRestauranteAlterar.Text != "" && textBoxCidadeRestauranteAlterar.Text != "" && textBoxCodPostalRestauranteAlterar.Text != "" && textBoxPaisRestauranteAlterar.Text != "" && listBoxRestaurantes.SelectedItem != null)
            {

                RestauranteSet restaurante = (RestauranteSet)listBoxRestaurantes.SelectedItem;
                restaurante.Nome = textBoxNomeRestauranteAlterar.Text;
                restaurante.MoradaSet.Rua = textBoxRuaRestauranteAlterar.Text;
                restaurante.MoradaSet.CodPostal = textBoxCodPostalRestauranteAlterar.Text;
                restaurante.MoradaSet.Cidade = textBoxCidadeRestauranteAlterar.Text;
                restaurante.MoradaSet.Pais = textBoxPaisRestauranteAlterar.Text;


                meuRestaurante.SaveChanges();
                LerDadosRestaurantes();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados para proceder a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LerDadosRestaurantes()
        {
            listBoxRestaurantes.DataSource = meuRestaurante.RestauranteSet.OfType<RestauranteSet>().ToList();
        }

        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestauranteSet restaurante = (RestauranteSet)listBoxRestaurantes.SelectedItem;
            textBoxNomeRestauranteAlterar.Text = restaurante.Nome;
            textBoxRuaRestauranteAlterar.Text = restaurante.MoradaSet.Rua;
            textBoxCodPostalRestauranteAlterar.Text = restaurante.MoradaSet.CodPostal;
            textBoxCidadeRestauranteAlterar.Text = restaurante.MoradaSet.Cidade;
            textBoxPaisRestauranteAlterar.Text = restaurante.MoradaSet.Pais;
        }


        //Metodos Pagamentos
        private void buttonAdicionarPagamento_Click(object sender, EventArgs e)
        {
            if (textBoxNomePagamento.Text != "" && comboBoxEstadoPagamento.SelectedIndex >= 0)
            {
                MetodoPagamentoSet metodoPagamento = new MetodoPagamentoSet();
                metodoPagamento.TipoMetodoPagamento = textBoxNomePagamento.Text;
                metodoPagamento.Ativo = (comboBoxEstadoPagamento.Text == "Ativado") ? true : false;

                meuRestaurante.MetodoPagamentoSet.Add(metodoPagamento);
                meuRestaurante.SaveChanges();

                LerDadosMetodosPagamento();

                textBoxNomePagamento.Text = "";
                comboBoxEstadoPagamento.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados para proceder a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        

        private void LerDadosMetodosPagamento()
        {
            listBoxMetodosPagamento.DataSource = meuRestaurante.MetodoPagamentoSet.OfType<MetodoPagamentoSet>().ToList();
        }

        private void buttonAlterarMetodosPagamento_Click(object sender, EventArgs e)
        {
            if (textBoxNomePagamentoAlterar.Text != "" && comboBoxEstadoPagamentoAlterar.SelectedIndex >= 0 && listBoxMetodosPagamento.SelectedItem != null )
            {
                MetodoPagamentoSet metodoPagamento = (MetodoPagamentoSet)listBoxMetodosPagamento.SelectedItem;
                metodoPagamento.TipoMetodoPagamento = textBoxNomePagamentoAlterar.Text;
                metodoPagamento.Ativo = (comboBoxEstadoPagamentoAlterar.Text == "Ativado") ? true : false;

                textBoxNomePagamentoAlterar.Text = "";
                comboBoxEstadoPagamentoAlterar.SelectedIndex = -1;
                meuRestaurante.SaveChanges();
                LerDadosMetodosPagamento();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados para proceder a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void buttonApagarMetodosPagamentos_Click(object sender, EventArgs e)
        {
            if (listBoxMetodosPagamento.SelectedIndex >= 0)
            {
                MetodoPagamentoSet metodoPagamento = (MetodoPagamentoSet)listBoxMetodosPagamento.SelectedItem;
                meuRestaurante.MetodoPagamentoSet.Remove(metodoPagamento);
                meuRestaurante.SaveChanges();
                LerDadosMetodosPagamento();
            }
            else
            {
                MessageBox.Show("Não selecionaste nenhum método de pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void listBoxMetodosPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPagamentoSet metodoPagamento = (MetodoPagamentoSet)listBoxMetodosPagamento.SelectedItem;
            textBoxNomePagamentoAlterar.Text = metodoPagamento.TipoMetodoPagamento;
            comboBoxEstadoPagamentoAlterar.SelectedIndex = metodoPagamento.Ativo ? 0 : 1;
        }

        //categorias
        private void buttonAdicionarCategoria_Click(object sender, EventArgs e)
        {
            if (textBoxNomeCategoria.Text != "" && comboBoxEstadoCategoria.SelectedIndex >= 0)
            {
                CategoriaSet categoria = new CategoriaSet();
                categoria.Nome = textBoxNomeCategoria.Text;
                categoria.Ativo = (comboBoxEstadoCategoria.Text == "Ativado") ? true : false;

                textBoxNomeCategoria.Text = "";
                comboBoxEstadoCategoria.SelectedIndex = -1;


                meuRestaurante.CategoriaSet.Add(categoria);
                meuRestaurante.SaveChanges();
                LerDadosCategorias();
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void buttonAlterarCategoria_Click(object sender, EventArgs e)
        {
            if(textBoxNomeCategoriaAlterar.Text != "" && comboBoxEstadoCategoriaAlterar.SelectedIndex >=0 && listBoxCategorias.SelectedItem != null) { 
                CategoriaSet categoria = (CategoriaSet)listBoxCategorias.SelectedItem;
                categoria.Nome = textBoxNomeCategoriaAlterar.Text;
                categoria.Ativo = (comboBoxEstadoCategoriaAlterar.Text == "Ativado") ? true : false;
                meuRestaurante.SaveChanges();
                LerDadosCategorias();
            }
            else
            {
                MessageBox.Show("Preencha e selecione os dados solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void LerDadosCategorias()
        {
            listBoxCategorias.DataSource = meuRestaurante.CategoriaSet.OfType<CategoriaSet>().ToList();
        }

        private void buttonApagarCategorias_Click(object sender, EventArgs e)
        {
            if (listBoxCategorias.SelectedIndex >= 0)
            {
                CategoriaSet categoria = (CategoriaSet)listBoxCategorias.SelectedItem;
                meuRestaurante.CategoriaSet.Remove(categoria);
                meuRestaurante.SaveChanges();
                LerDadosCategorias();
            }
            else
            {
                MessageBox.Show("Não selecionaste nenhuma categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoriaSet categoria = (CategoriaSet)listBoxCategorias.SelectedItem;
            textBoxNomeCategoriaAlterar.Text = categoria.Nome;

            comboBoxEstadoCategoriaAlterar.SelectedIndex = categoria.Ativo ? 0 : 1;

        }

        private void textBoxCodPostalRestaurante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxCodPostalRestauranteAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '-'))
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