using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestGest
{
    public partial class FormPedidos : Form
    {
        public static meuRestauranteContainer meuRestaurante;
        public RestauranteSet restaurante;
        public int restauranteId;
        private static string path;

        public FormPedidos(RestauranteSet rest)
        {
            InitializeComponent();
            restauranteId = rest.Id;

        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

            meuRestaurante = new meuRestauranteContainer();
            restaurante = meuRestaurante.RestauranteSet.Find(restauranteId);
            LerDadosCliente();
            LerDadosTrabalhador();
            LerDadosPedido();
            LerDadosEstados();
            LerDadosMetodosPagamento();
            LerDadosPagamentos();
        }

        private void LerDadosCliente()
        {
            List<PessoaSet_Cliente> listaClientes = meuRestaurante.PessoaSet_Cliente.OfType<PessoaSet_Cliente>().ToList();
            List<PessoaSet_Cliente> listaClientesAtivos = new List<PessoaSet_Cliente>();
            foreach (PessoaSet_Cliente trabalhador in listaClientes)
            {
                if (trabalhador.PessoaSet.Ativo )
                {
                    listaClientesAtivos.Add(trabalhador);
                }
            }
            comboBoxCliente.DataSource = listaClientesAtivos;
        }

        public void LerDadosPedido()
        {
            listBoxPedidos.DataSource = meuRestaurante.PedidoSet.OfType<PedidoSet>().ToList();
        }

        public void LerDadosTrabalhador()
        {
            List<PessoaSet_Trabalhador> listaTrabalhadores = meuRestaurante.PessoaSet_Trabalhador.OfType<PessoaSet_Trabalhador>().ToList();
            List<PessoaSet_Trabalhador> listaTrabalhadoresAtivos = new List<PessoaSet_Trabalhador>();
            foreach ( PessoaSet_Trabalhador trabalhador in listaTrabalhadores)
            {
                if(trabalhador.PessoaSet.Ativo  && trabalhador.IdRestaurante == restaurante.Id)
                {
                    listaTrabalhadoresAtivos.Add(trabalhador); 
                }
            }
            comboBoxTrabalhador.DataSource = listaTrabalhadoresAtivos;

        }

        public void LerDadosEstados()
        {
            comboBoxEstadoAtual.DataSource = meuRestaurante.EstadoSet.OfType<EstadoSet>().ToList();
            comboBoxFiltro.DataSource = meuRestaurante.EstadoSet.OfType<EstadoSet>().ToList();
        }

        public void LerDadosMetodosPagamento()
        {
            List<MetodoPagamentoSet> metodosPagamento = meuRestaurante.MetodoPagamentoSet.OfType<MetodoPagamentoSet>().ToList();

            List<MetodoPagamentoSet> metodosPagamentoNaoSelecionados = new List<MetodoPagamentoSet>();


            foreach (MetodoPagamentoSet metodo in metodosPagamento){
                if(metodo.Ativo)
                {
                    metodosPagamentoNaoSelecionados.Add(metodo);
                }
            };

            listBoxMetodoPagamento.DataSource = metodosPagamentoNaoSelecionados;
        }

        public void LerDadosPagamentos()
        {
            if(listBoxPedidos.SelectedItem != null)
            {
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
                listBoxMetodoPagamentoUtilizado.DataSource = pedido.PagamentoSet.ToList();
            }

        }


        public void LerDadosMenus()
        {

            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;

            List<ItemMenuSet> listaItensRestaurante = restaurante.ItemMenuSet.OfType<ItemMenuSet>().ToList();

            List<ItemMenuSet> listaMenusSelecionados = new List<ItemMenuSet>();
            List<ItemMenuSet> listaMenusNaoSelecionados = new List<ItemMenuSet>();
            foreach (ItemMenuSet menu in listaItensRestaurante)
            {
                if (menu.PedidoSet.Contains(pedido))
                {
                    listaMenusSelecionados.Add(menu);
                }
                else
                {
                    listaMenusNaoSelecionados.Add(menu);
                }


            }

            listBoxMenuRestaurante.DataSource = listaMenusNaoSelecionados;
            listBoxItensPedidos.DataSource = listaMenusSelecionados;
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCliente.SelectedItem != null) { 
                PessoaSet_Cliente cliente = (PessoaSet_Cliente)comboBoxCliente.SelectedItem;

                labelContribuinteCliente.Text = cliente.NumContribuinte.ToString();
                labelMoradaCliente.Text = cliente.PessoaSet.MoradaSet.ToString();
            }

        }

        private void comboBoxTrabalhador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTrabalhador.SelectedItem != null)
            {
                PessoaSet_Trabalhador trabalhador = (PessoaSet_Trabalhador)comboBoxTrabalhador.SelectedItem;

                labelPosicaoTrabalhador.Text = trabalhador.Posicao;
            }

        }

        private void buttonAdicionarPedido_Click(object sender, EventArgs e)
        {
            if(comboBoxTrabalhador.SelectedItem != null && comboBoxCliente.SelectedItem != null)
            {

                PedidoSet pedido = new PedidoSet();
                PessoaSet_Trabalhador pessoaSet_Trabalhador = (PessoaSet_Trabalhador)comboBoxTrabalhador.SelectedItem;
                PessoaSet_Cliente pessoaSetCliente = (PessoaSet_Cliente)comboBoxCliente.SelectedItem;
                pedido.PessoaSet_Trabalhador = pessoaSet_Trabalhador;
                pedido.PessoaSet_Cliente = pessoaSetCliente;
                pedido.RestauranteSet = meuRestaurante.RestauranteSet.OfType<RestauranteSet>().First();
                pedido.EstadoSet = (EstadoSet)comboBoxEstadoAtual.Items[0];
                /*PagamentoSet pagamento = new PagamentoSet();
                pagamento.MetodoPagamentoSet = meuRestaurante.MetodoPagamentoSet.OfType<MetodoPagamentoSet>().First();
                pagamento.Valor = 0;*/
                //pedido.ItemMenuSet.Add(meuRestaurante.ItemMenuSet.OfType<ItemMenuSet>().First());
                //pedido.PagamentoSet.Add(pagamento);
                pedido.ValorTotal = 0;

                meuRestaurante.PedidoSet.Add(pedido);
                //meuRestaurante.PagamentoSet.Add(pagamento);
                meuRestaurante.SaveChanges();

                LerDadosPedido();
            }
            else
            {
                MessageBox.Show("Selecione todos os dados solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFiltro.SelectedItem != null)
            {
                List<PedidoSet> Pedidos = meuRestaurante.PedidoSet.OfType<PedidoSet>().ToList();
                EstadoSet estado = (EstadoSet)comboBoxFiltro.SelectedItem;

                List<PedidoSet> PedidosSelecionados = new List<PedidoSet>();

                foreach (PedidoSet pedido in Pedidos)
                {
                    if (pedido.EstadoSet == estado)
                    {
                        PedidosSelecionados.Add(pedido);
                    }
                };

                listBoxPedidos.DataSource = PedidosSelecionados;

            }
        }

        private void comboBoxEstadoAtual_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstadoSet estado = (EstadoSet)comboBoxEstadoAtual.SelectedItem;
            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            //pedido.EstadoSet = estado;

            //meuRestaurante.SaveChanges();
        }

        private void listBoxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            comboBoxEstadoAtual.SelectedItem = pedido.EstadoSet;
            LerDadosMenus();
            labelNomeClienteConsultar.Text = pedido.PessoaSet_Cliente.PessoaSet.Nome;
            labelMoradaClienteConsultar.Text = pedido.PessoaSet_Cliente.PessoaSet.MoradaSet.ToString();
            labelContribuinteClineteConsultar.Text = pedido.PessoaSet_Cliente.NumContribuinte.ToString();
            LerDadosMetodosPagamento();
            LerDadosPagamentos();
            labelTotal.Text = pedido.ValorTotal.ToString();

        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            if(listBoxPedidos.SelectedItem != null && listBoxMenuRestaurante.SelectedItem != null)
            {
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
                pedido.ItemMenuSet.Add((ItemMenuSet)listBoxMenuRestaurante.SelectedItem);
                meuRestaurante.SaveChanges();

                LerDadosPedido();

            }


        }

        private void buttonRemoverItem_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null && listBoxItensPedidos.SelectedItem != null)
            {
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
                pedido.ItemMenuSet.Remove((ItemMenuSet)listBoxItensPedidos.SelectedItem);
                meuRestaurante.SaveChanges();

                LerDadosPedido();

            }
        }

        private void buttonAdicionarMetodoPagamento_Click(object sender, EventArgs e)
        {
            if( listBoxPedidos.SelectedItem != null && listBoxMetodoPagamento.SelectedItem != null && textBoxValorMetodoPagamento.Text != "")
            {
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;

                PagamentoSet pagamento = new PagamentoSet();
                pagamento.MetodoPagamentoSet = (MetodoPagamentoSet)listBoxMetodoPagamento.SelectedItem;
                pagamento.Valor = float.Parse(textBoxValorMetodoPagamento.Text);
                pagamento.PedidoSet = pedido;

                meuRestaurante.PagamentoSet.Add(pagamento);
                meuRestaurante.SaveChanges();

                LerDadosPedido();
                LerDadosMetodosPagamento();
                LerDadosPagamentos();

            }

        }

        private void buttonRemoverMetodoPagamento_Click(object sender, EventArgs e)
        {
            if(listBoxPedidos.SelectedItem != null && listBoxMetodoPagamentoUtilizado.SelectedItem != null)
            {

                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;

                PagamentoSet pagamento = (PagamentoSet)listBoxMetodoPagamentoUtilizado.SelectedItem;
                pagamento.PedidoSet = pedido;

                meuRestaurante.PagamentoSet.Remove(pagamento);
                meuRestaurante.SaveChanges();

                LerDadosPedido();
                LerDadosMetodosPagamento();
                LerDadosPagamentos();
            }


        }

        private void buttonExportarTxt_Click(object sender, EventArgs e)
        {
            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            


            path = "./faturas/fatura_" + pedido.Id + ".txt";
            File.AppendAllText(path, Environment.NewLine + "Restaurante: " + pedido.RestauranteSet.Nome + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "--------------------------------------------" + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "Fatura Nº: "+ pedido.Id + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "Funcionario: " + pedido.PessoaSet_Trabalhador.PessoaSet.Nome + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "--------------------------------------------" + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "Cliente: " + pedido.PessoaSet_Cliente.PessoaSet.Nome + Environment.NewLine + "Nº Contribuinte: " + pedido.PessoaSet_Cliente.NumContribuinte + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "--------------------------------------------" + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "Itens : " + Environment.NewLine);
            foreach (ItemMenuSet menu in listBoxItensPedidos.Items)
            {

                File.AppendAllText(path, Environment.NewLine + menu.ToString() + Environment.NewLine);

            }
            File.AppendAllText(path, Environment.NewLine + "--------------------------------------------" + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "Total:"+ pedido.ValorTotal + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "--------------------------------------------" + Environment.NewLine);
            File.AppendAllText(path, Environment.NewLine + "Metodos pagamento"+ Environment.NewLine);
            foreach (PagamentoSet pagamento in listBoxMetodoPagamentoUtilizado.Items)
            {

                File.AppendAllText(path, Environment.NewLine + pagamento.ToString() + Environment.NewLine);

            }
            File.AppendAllText(path, Environment.NewLine + "Obrigado, volte sempre!" + Environment.NewLine);
        }

        private void buttonExportarPdf_Click(object sender, EventArgs e)
        {

        }
    }
}
