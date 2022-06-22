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
using SautinSoft.Document;
using SautinSoft.Document.Drawing;


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
            LerDadosMetodos();
            LerDadosTrabalhador();
            LerDadosPedido();
            LerDadosEstados();
        }
        private float CalcularTotalPago()
        {
            float totalPago = 0;
            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            List<PagamentoSet> listaPagamentos = pedido.PagamentoSet.ToList();
            foreach (PagamentoSet pagamento in listaPagamentos)
            {
                totalPago = totalPago + pagamento.Valor;
            }
            return totalPago;
        }

        private float CalcularRestantePagar()
        {
            float restantePagar = 0;
            float totalPago = CalcularTotalPago();
            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            restantePagar = pedido.ValorTotal - totalPago;
            return restantePagar;
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
        private void LerDadosMetodos()
        {
            List<MetodoPagamentoSet> listaMetodos = meuRestaurante.MetodoPagamentoSet.OfType<MetodoPagamentoSet>().ToList();
            List<MetodoPagamentoSet> listaMetodosAtivos = new List<MetodoPagamentoSet>();
            foreach (MetodoPagamentoSet metodo in listaMetodos)
            {
                if (metodo.Ativo)
                {
                    listaMetodosAtivos.Add(metodo);
                }
            }
            comboBoxMetodosPagamentos.DataSource = listaMetodosAtivos;
        }

        public void LerDadosPedido()
        {
            listBoxPedidos.DataSource = meuRestaurante.PedidoSet.OfType<PedidoSet>().ToList();

            List<PedidoSet> listaPedidos = meuRestaurante.PedidoSet.OfType<PedidoSet>().ToList();
            List<PedidoSet> listaPedidosSelecionados = new List<PedidoSet>();
            foreach (PedidoSet pedido in listaPedidos)
            {
                if (pedido.RestauranteSet == restaurante)
                {
                    listaPedidosSelecionados.Add(pedido);
                }
            }
            listBoxPedidos.DataSource = listaPedidosSelecionados;
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
            /*if(listBoxPedidos.SelectedItem != null)
            { */
                try
                { 
                    List<MetodoPagamentoSet> metodosPagamento = meuRestaurante.MetodoPagamentoSet.OfType<MetodoPagamentoSet>().ToList();

                    List<MetodoPagamentoSet> metodosPagamentoNaoSelecionados = new List<MetodoPagamentoSet>();
                    List<MetodoPagamentoSet> metodosPagamentoUtilizados = new List<MetodoPagamentoSet>();

                    PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;

                    List < PagamentoSet> pagamentos = pedido.PagamentoSet.ToList();
                    foreach(PagamentoSet pagamento in pagamentos)
                    {
                        metodosPagamentoUtilizados.Add(pagamento.MetodoPagamentoSet);
                    }


                    foreach (MetodoPagamentoSet metodo in metodosPagamento){
                        if(metodo.Ativo &&  !(metodosPagamentoUtilizados.Contains(metodo)))
                        {
                            metodosPagamentoNaoSelecionados.Add(metodo);
                        }
                    };

                    listBoxMetodoPagamento.DataSource = metodosPagamentoNaoSelecionados;
                }
                catch(Exception ex)
                {

                }
            //}
        }

        public void LerDadosPagamentos()
        {
            listBoxMetodoPagamentoUtilizado.DataSource = null;
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

        public void redefinirForm()
        {
            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            if (pedido.EstadoSet.EstadoAtual == "Recebido")
            {
                comboBoxEstadoAtual.Enabled = true;
                buttonExportarTxt.Enabled = false;
                buttonExportarPdf.Enabled = false;
                buttonAdicionarItem.Enabled = false;
                buttonRemoverItem.Enabled = false;
                buttonAdicionarMetodoPagamento.Enabled = false;
                buttonRemoverMetodoPagamento.Enabled = false;
                buttonRestanteMetodoPagamento.Enabled = false;

            }
            else if (pedido.EstadoSet.EstadoAtual == "Em processamento")
            {
                comboBoxEstadoAtual.Enabled = true;
                buttonExportarTxt.Enabled = false;
                buttonExportarPdf.Enabled = false;
                buttonAdicionarItem.Enabled = true;
                buttonRemoverItem.Enabled = true;
                buttonAdicionarMetodoPagamento.Enabled = true;
                buttonRemoverMetodoPagamento.Enabled = true;
                buttonRestanteMetodoPagamento.Enabled = true;
            }
            else if (pedido.EstadoSet.EstadoAtual == "Cancelado")
            {
                comboBoxEstadoAtual.Enabled = false;
                buttonExportarTxt.Enabled = false;
                buttonExportarPdf.Enabled = false;
                buttonAdicionarItem.Enabled = false;
                buttonRemoverItem.Enabled = false;
                buttonAdicionarMetodoPagamento.Enabled = false;
                buttonRemoverMetodoPagamento.Enabled = false;
                buttonRestanteMetodoPagamento.Enabled = false;
            }
            else if (pedido.EstadoSet.EstadoAtual == "Concluido")
            {
                comboBoxEstadoAtual.Enabled = false;
                buttonExportarTxt.Enabled = true;
                buttonExportarPdf.Enabled = true;
                buttonAdicionarItem.Enabled = false;
                buttonRemoverItem.Enabled = false;
                buttonAdicionarMetodoPagamento.Enabled = false;
                buttonRemoverMetodoPagamento.Enabled = false;
                buttonRestanteMetodoPagamento.Enabled = false;
            }
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
                PagamentoSet pagamento = new PagamentoSet();
                pagamento.MetodoPagamentoSet = (MetodoPagamentoSet)comboBoxMetodosPagamentos.SelectedItem;
                pagamento.Valor = 0;
                pagamento.PedidoSet = pedido;
                pedido.ValorTotal = 0;

                meuRestaurante.PedidoSet.Add(pedido);
                meuRestaurante.PagamentoSet.Add(pagamento);
                meuRestaurante.SaveChanges();

                LerDadosPedido();
                LerDadosMetodosPagamento();
                LerDadosPagamentos();
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
                    if (pedido.EstadoSet == estado && pedido.RestauranteSet == restaurante)
                    {
                        PedidosSelecionados.Add(pedido);
                    }
                };

                listBoxPedidos.DataSource = PedidosSelecionados;

            }
        }

        private void comboBoxEstadoAtual_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPedidos.SelectedItem != null)
            {
                EstadoSet estado = (EstadoSet)comboBoxEstadoAtual.SelectedItem;
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
                string valor = CalcularTotalPago().ToString("0.00");
                if(estado.EstadoAtual == "Concluido" && pedido.ItemMenuSet.ToList().Count() == 0)
                {
                    comboBoxEstadoAtual.SelectedItem = pedido.EstadoSet;
                    MessageBox.Show("Nao pode concluir o pedido sem itens!");

                } else if (estado.EstadoAtual == "Concluido" && pedido.ValorTotal.ToString() == valor)
                {
                    pedido.EstadoSet = estado;
                }else if(estado.EstadoAtual == "Concluido" && pedido.ValorTotal != CalcularTotalPago())
                {
                    comboBoxEstadoAtual.SelectedItem = pedido.EstadoSet;
                    MessageBox.Show("Tem que pagar a totalidade do pedido \n antes de marcar como concluido!");
                }
                else
                {
                    pedido.EstadoSet = estado;
                }

                meuRestaurante.SaveChanges();
                redefinirForm();
            }
            else
            {
                MessageBox.Show("Selecione todos os dados solicitados!");
            }
            
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
            labelTotal.Text = pedido.ValorTotal + " €";
            redefinirForm();

        }

        private void buttonAdicionarItem_Click(object sender, EventArgs e)
        {
            if(listBoxPedidos.SelectedItem != null && listBoxMenuRestaurante.SelectedItem != null)
            {
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
                ItemMenuSet item = (ItemMenuSet)listBoxMenuRestaurante.SelectedItem;
                pedido.ItemMenuSet.Add(item);
                pedido.ValorTotal = pedido.ValorTotal + item.Preco;
                meuRestaurante.SaveChanges();

                LerDadosPedido();
                listBoxPedidos.SelectedItem = pedido;

            }
            else
            {
                MessageBox.Show("Selecione todos os dados solicitados!");
            }


        }

        private void buttonRemoverItem_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null && listBoxItensPedidos.SelectedItem != null)
            {
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
                ItemMenuSet item = (ItemMenuSet)listBoxItensPedidos.SelectedItem;
                pedido.ItemMenuSet.Remove(item);
                pedido.ValorTotal = pedido.ValorTotal - item.Preco;

                meuRestaurante.SaveChanges();

                LerDadosPedido();
                listBoxPedidos.SelectedItem = pedido;

            }
            else
            {
                MessageBox.Show("Selecione todos os dados solicitados!");
            }
        }

        private void buttonAdicionarMetodoPagamento_Click(object sender, EventArgs e)
        {
            if( listBoxPedidos.SelectedItem != null && listBoxMetodoPagamento.SelectedItem != null && textBoxValorMetodoPagamento.Text != "")
            {
                if(float.Parse(textBoxValorMetodoPagamento.Text) > CalcularRestantePagar())
                {
                    MessageBox.Show("Nao pode pagar mais que o valor total do pedido!");
                }
                else
                {
                    PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;

                    PagamentoSet pagamento = new PagamentoSet();
                    pagamento.MetodoPagamentoSet = (MetodoPagamentoSet)listBoxMetodoPagamento.SelectedItem;
                    pagamento.Valor = float.Parse(textBoxValorMetodoPagamento.Text);
                    pagamento.PedidoSet = pedido;

                    meuRestaurante.PagamentoSet.Add(pagamento);
                    meuRestaurante.SaveChanges();

                    LerDadosMetodosPagamento();
                    LerDadosPagamentos();
                }

            }
            else
            {
                MessageBox.Show("Insira e selecione todos os dados solicitados!");
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
            else
            {
                MessageBox.Show("Selecione todos os dados solicitados!");
            }


        }

        private void buttonExportarTxt_Click(object sender, EventArgs e)
        {
            PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;
            


            path = "./faturas/fatura_" + pedido.Id + ".txt";
            File.Create(path);
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
            try { 
                PedidoSet pedido = (PedidoSet)listBoxPedidos.SelectedItem;

                // Set a path to our document.
                string docPath = @"./faturas/fatura_" + pedido.Id + ".pdf";

                // Create a new document and DocumentBuilder.
                DocumentCore dc = new DocumentCore();
                DocumentBuilder db = new DocumentBuilder(dc);

                // Set page size A4.
                Section section = db.Document.Sections[0];
                section.PageSetup.PaperType = PaperType.A4;

                // Add 1st paragraph with formatted text.
                db.CharacterFormat.FontName = "Colibri";
                db.CharacterFormat.Size = 16;

                db.Write(Environment.NewLine + "Restaurante: " + pedido.RestauranteSet.Nome );
                db.Write(Environment.NewLine + "--------------------------------------------" );
                db.Write(Environment.NewLine + "Fatura Nº: " + pedido.Id );
                db.Write(Environment.NewLine + "Funcionario: " + pedido.PessoaSet_Trabalhador.PessoaSet.Nome );
                db.Write(Environment.NewLine + "--------------------------------------------" );
                db.Write(Environment.NewLine + "Cliente: " + pedido.PessoaSet_Cliente.PessoaSet.Nome + Environment.NewLine + "Nº Contribuinte: " + pedido.PessoaSet_Cliente.NumContribuinte);
                db.Write(Environment.NewLine + "--------------------------------------------" );
                db.Write(Environment.NewLine + "Itens : ");
                foreach (ItemMenuSet menu in listBoxItensPedidos.Items)
                {

                    db.Write(Environment.NewLine + menu.ToString());

                }
                db.Write(Environment.NewLine + "--------------------------------------------" );
                db.Write( Environment.NewLine + "Total:" + pedido.ValorTotal);
                db.Write( Environment.NewLine + "--------------------------------------------" );
                db.Write(Environment.NewLine + "Metodos pagamento" );
                foreach (PagamentoSet pagamento in listBoxMetodoPagamentoUtilizado.Items)
                {

                    db.Write(Environment.NewLine + pagamento.ToString());

                }
                db.Write(Environment.NewLine + "--------------------------------------------");
                db.Write(Environment.NewLine + "Obrigado, volte sempre!");
                // Add a graphics figure into the paragraph.
                db.CharacterFormat.ClearFormatting();
                Shape shape = db.InsertShape(SautinSoft.Document.Drawing.Figure.SmileyFace, new SautinSoft.Document.Drawing.Size(5, 5, LengthUnit.Millimeter));
                // Specify outline and fill.
                shape.Outline.Fill.SetSolid(new SautinSoft.Document.Color("#358CCB"));
                shape.Outline.Width = 1;
                shape.Fill.SetSolid(SautinSoft.Document.Color.Orange);

                // Save the document to the file in PDF format.
                dc.Save(docPath, new PdfSaveOptions()
                { Compliance = PdfCompliance.PDF_A1a });
            }
            catch(Exception ex)
            {
                
            }

        }

        private void buttonRestanteMetodoPagamento_Click(object sender, EventArgs e)
        {
            if(listBoxPedidos.SelectedItem != null)
            {
                textBoxValorMetodoPagamento.Text = CalcularRestantePagar().ToString();
            }
            else
            {
                MessageBox.Show("Selecione um pedido!");
            }
        }

        private void textBoxValorMetodoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }
    }
}

