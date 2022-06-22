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
            LerDadosTrabalhadores();
            LerDadosMenus();
        }

        private void FormIndividualRestaurante_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxAdcMenusPedidos_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerDadosTrabalhadores();
            LerInformacoesRestaurante();
            LerDadosMenus();
        }


        private void LerDadosRestaurantes()
        {
            comboBoxRestaurantes.DataSource = meuRestaurante.RestauranteSet.OfType<RestauranteSet>().ToList();
        }

        private void LerInformacoesRestaurante()
        {
            if(comboBoxRestaurantes.SelectedItem != null)
            { 
                RestauranteSet restaurante = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
                labelNumeroTrabalhadores.Text = "Nº Trabalhadores: " + restaurante.GetNumeroTrabalhadores();
                labelNumeroPedidos.Text = "Nº Pedidos: " + restaurante.GetNumeroPedidos();
                labelTotalFaturado.Text = "Total Faturado: " + restaurante.GetTotalFaturado();
                labelTotalSalarios.Text = restaurante.GetTotalSalarios() + " €";
            }
        }

        private void LerDadosTrabalhadores()
        {

            RestauranteSet restaurante = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
            List < PessoaSet_Trabalhador > listaTrabalhadores = meuRestaurante.PessoaSet_Trabalhador.OfType<PessoaSet_Trabalhador>().ToList();
            List<PessoaSet_Trabalhador> listaTrabalhadoresSelecionados = new List<PessoaSet_Trabalhador>();
            foreach (PessoaSet_Trabalhador  trabalhador in listaTrabalhadores)
            {
                if(trabalhador.RestauranteSet == restaurante)
                {
                    listaTrabalhadoresSelecionados.Add(trabalhador);
                }
            }
            
                listBoxTrabalhadores.DataSource = listaTrabalhadoresSelecionados;
            LerInformacoesRestaurante();
        }

        private void buttonAdicionarTrabalhador_Click(object sender, EventArgs e)
        {
            if(textBoxNomeTrabalhador.Text != "" && textBoxNomeTrabalhador.Text != "" && textBoxTelemovelTrabalhador.Text != "" && textBoxPosicaoTrabalhador.Text != "" && textBoxSalarioTrabalhador.Text != "" && textBoxCidadeTrabalhador.Text != "" && textBoxCodPostalTrabalhador.Text!= "" && textBoxPaisTrabalhador.Text != "" && textBoxRuaTrabalhador.Text != "" && comboBoxEstadoTrabalhador.SelectedIndex >= 0 && comboBoxRestaurantes.SelectedItem != null)
            { 
                PessoaSet Pessoa = new PessoaSet();
                Pessoa.Nome = textBoxNomeTrabalhador.Text;
                Pessoa.Telemovel = Int32.Parse(textBoxTelemovelTrabalhador.Text);
                Pessoa.Ativo = (comboBoxEstadoTrabalhador.Text == "Ativado") ? true : false;
                PessoaSet_Trabalhador trabalhador = new PessoaSet_Trabalhador();
                trabalhador.PessoaSet = Pessoa;
                trabalhador.RestauranteSet = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
                trabalhador.Salario = Int32.Parse(textBoxSalarioTrabalhador.Text);
                trabalhador.Posicao = textBoxPosicaoTrabalhador.Text;
                MoradaSet trabalhadorMorada = new MoradaSet();
                trabalhadorMorada.Rua = textBoxRuaTrabalhador.Text;
                trabalhadorMorada.Cidade = textBoxCidadeTrabalhador.Text;
                trabalhadorMorada.CodPostal = textBoxCodPostalTrabalhador.Text;
                trabalhadorMorada.Pais = textBoxPaisTrabalhador.Text;
                Pessoa.MoradaSet = trabalhadorMorada;


                meuRestaurante.PessoaSet_Trabalhador.Add(trabalhador);
                meuRestaurante.MoradaSet.Add(trabalhadorMorada);
                meuRestaurante.SaveChanges();
                LerDadosTrabalhadores();

                //Limpar as textBoxes
                textBoxNomeTrabalhador.Text = "";
                textBoxTelemovelTrabalhador.Text = "";
                comboBoxEstadoTrabalhador.SelectedIndex = 0;
                textBoxSalarioTrabalhador.Text = "";
                textBoxPosicaoTrabalhador.Text = "";
                textBoxRuaTrabalhador.Text = "";
                textBoxCidadeTrabalhador.Text = "";
                textBoxCodPostalTrabalhador.Text = "";
                textBoxPaisTrabalhador.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditarTrabalhador_Click(object sender, EventArgs e)
        {
            if (textBoxNomeTrabalhadorAlterar.Text != "" && textBoxNomeTrabalhadorAlterar.Text != "" && textBoxTelemovelTrabalhadorAlterar.Text != "" && textBoxPosicaoTrabalhadorAlterar.Text != "" && textBoxSalarioTrabalhadorAlterar.Text != "" && textBoxRuaTrabalhadorAlterar.Text != "" && textBoxCodPostalTrabalhadorAlterar.Text != "" && textBoxCidadeTrabalhadorAlterar.Text != "" && textBoxPaisTrabalhadorAlterar.Text != "" && comboBoxEstadoTrabalhadorAlterar.SelectedIndex >= 0 && listBoxTrabalhadores.SelectedItem != null)
            {

                PessoaSet_Trabalhador trabalhador = (PessoaSet_Trabalhador)listBoxTrabalhadores.SelectedItem;
                trabalhador.PessoaSet.Nome = textBoxNomeTrabalhadorAlterar.Text;
                trabalhador.PessoaSet.Telemovel = Int32.Parse(textBoxTelemovelTrabalhadorAlterar.Text);
                trabalhador.Posicao = textBoxPosicaoTrabalhadorAlterar.Text;
                trabalhador.Salario = Int32.Parse(textBoxSalarioTrabalhadorAlterar.Text);
                trabalhador.PessoaSet.MoradaSet.Rua = textBoxRuaTrabalhadorAlterar.Text;
                trabalhador.PessoaSet.MoradaSet.CodPostal = textBoxCodPostalTrabalhadorAlterar.Text;
                trabalhador.PessoaSet.MoradaSet.Cidade = textBoxCidadeTrabalhadorAlterar.Text;
                trabalhador.PessoaSet.MoradaSet.Pais = textBoxPaisTrabalhadorAlterar.Text;
                trabalhador.PessoaSet.Ativo = (comboBoxEstadoTrabalhadorAlterar.Text == "Ativado") ? true : false;
                meuRestaurante.SaveChanges();
                LerDadosTrabalhadores();

            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            PessoaSet_Trabalhador trabalhador = (PessoaSet_Trabalhador)listBoxTrabalhadores.SelectedItem;
            textBoxNomeTrabalhadorAlterar.Text = trabalhador.PessoaSet.Nome;
            textBoxTelemovelTrabalhadorAlterar.Text = trabalhador.PessoaSet.Telemovel.ToString();
            textBoxPosicaoTrabalhadorAlterar.Text = trabalhador.Posicao;
            textBoxSalarioTrabalhadorAlterar.Text = trabalhador.Salario.ToString();
            textBoxRuaTrabalhadorAlterar.Text = trabalhador.PessoaSet.MoradaSet.Rua;
            textBoxCodPostalTrabalhadorAlterar.Text = trabalhador.PessoaSet.MoradaSet.CodPostal;
            textBoxCidadeTrabalhadorAlterar.Text = trabalhador.PessoaSet.MoradaSet.Cidade;
            textBoxPaisTrabalhadorAlterar.Text = trabalhador.PessoaSet.MoradaSet.Pais;
            comboBoxEstadoTrabalhadorAlterar.SelectedIndex = trabalhador.PessoaSet.Ativo ? 0 : 1;
        }

        private void buttonAdicionarMenu_Click(object sender, EventArgs e)
        {
            if (listBoxMenus.SelectedItem != null && comboBoxRestaurantes.SelectedItem != null)
            {
                RestauranteSet restaurante = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
                ItemMenuSet itemMenu = (ItemMenuSet)listBoxMenus.SelectedItem;
                itemMenu.RestauranteSet.Add(restaurante);
                meuRestaurante.SaveChanges();
                LerDadosMenus();
            }
            else
            {
                MessageBox.Show("Selecione o Menu e o respeitvo restaurante onde pretende que seja adicionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoverMenu_Click(object sender, EventArgs e)
        {
            if (listBoxMenuRestaurante.SelectedItem != null && comboBoxRestaurantes.SelectedItem != null)
            {
                RestauranteSet restaurante = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
                ItemMenuSet itemMenu = (ItemMenuSet)listBoxMenuRestaurante.SelectedItem;
                itemMenu.RestauranteSet.Remove(restaurante);
                meuRestaurante.SaveChanges();
                LerDadosMenus();
            }
            else
            {
                MessageBox.Show("Selecione o Menu e o respeitvo restaurante onde pretende que seja removido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void LerDadosMenus()
        {

            RestauranteSet restaurante = (RestauranteSet)comboBoxRestaurantes.SelectedItem;
            List<ItemMenuSet> listaMenus = meuRestaurante.ItemMenuSet.OfType<ItemMenuSet>().ToList();

            List<ItemMenuSet> listaMenusSelecionados = new List<ItemMenuSet>();
            List<ItemMenuSet> listaMenusNaoSelecionados = new List<ItemMenuSet>();
            foreach (ItemMenuSet menu in listaMenus)
            {
                if (menu.Ativo)
                {
                    if (menu.RestauranteSet.Contains(restaurante))
                    {
                        listaMenusSelecionados.Add(menu);
                    }
                    else
                    {
                        listaMenusNaoSelecionados.Add(menu);
                    }
                }
            }

            listBoxMenus.DataSource = listaMenusNaoSelecionados;
            listBoxMenuRestaurante.DataSource = listaMenusSelecionados;
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            if(comboBoxRestaurantes.SelectedItem != null)
            {
                FormPedidos form = new FormPedidos((RestauranteSet)comboBoxRestaurantes.SelectedItem);
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tem que selecionar um restaurante!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void textBoxCodPostalTrabalhador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodPostalTrabalhadorAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

        }

        private void textBoxTelemovelTrabalhador_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSalarioTrabalhador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxTelemovelTrabalhadorAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxSalarioTrabalhadorAlterar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void buttonApagarRestaurantes_Click(object sender, EventArgs e)
        {

        }
    }
}