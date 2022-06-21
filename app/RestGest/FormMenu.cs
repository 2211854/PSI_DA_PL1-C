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
    public partial class FormMenu : Form
    {
        public static meuRestauranteContainer meuRestaurante;

        public FormMenu()
        {
            meuRestaurante = new meuRestauranteContainer();
            InitializeComponent();
            LerDadosMenu();
            LerCategorias();
        }

        

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "" && comboBoxEstado.SelectedIndex >= 0)
            {
                CategoriaSet categoria = (CategoriaSet)comboBoxCategoria.SelectedItem;

                ItemMenuSet itemMenu = new ItemMenuSet();
                itemMenu.Nome = textBoxNome.Text;
                itemMenu.Fotografia = textBoxImageString.Text;
                itemMenu.IdCategoria = categoria.Id;
                itemMenu.Ativo = (comboBoxEstado.Text == "Ativado") ? true : false;
                itemMenu.Ingredientes = textBoxIngredientes.Text;

                itemMenu.CategoriaSet = categoria;

                try
                {
                    itemMenu.Preco =  float.Parse(textBoxPreco.Text);
                    meuRestaurante.ItemMenuSet.Add(itemMenu);
                    meuRestaurante.SaveChanges();

                    LerDadosMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Preço inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados para proceder a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            if (textBoxNomeAlterar.Text != "" && comboBoxEstadoAlterar.SelectedIndex >= 0)
            {
                CategoriaSet categoria = (CategoriaSet)comboBoxCategoria.SelectedItem;

                ItemMenuSet itemMenu = (ItemMenuSet)listBoxItens.SelectedItem;
                itemMenu.Nome = textBoxNomeAlterar.Text;
                itemMenu.Fotografia = textBoxImageStringAlterar.Text;
                itemMenu.IdCategoria = categoria.Id;
                itemMenu.Ativo = (comboBoxEstadoAlterar.Text == "Ativado") ? true : false;
                itemMenu.Ingredientes = textBoxIngredientesAlterar.Text;

                itemMenu.CategoriaSet = categoria;

                try
                {
                    itemMenu.Preco = float.Parse(textBoxPrecoAlterar.Text);
                    meuRestaurante.SaveChanges();
                    LerDadosMenu();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Preço inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados solicitados para proceder a alteração!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonUploadAlterar_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxItemAlterar.Image = new Bitmap(open.FileName);
                using (Image image = pictureBoxItemAlterar.Image.Clone() as Image)
                {
                    textBoxImageStringAlterar.Text = ConvertImageToBase64(image);
                }
            }
        }


        public void LerDadosMenu()
        {
            listBoxItens.DataSource = meuRestaurante.ItemMenuSet.OfType<ItemMenuSet>().ToList();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBoxItem.Image = new Bitmap(open.FileName);
                using (Image image = pictureBoxItem.Image.Clone() as Image)
                {
                    textBoxImageString.Text = ConvertImageToBase64(image);
                }
            }
        }


        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        public Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        public void LerCategorias()
        {
            comboBoxCategoria.DataSource = meuRestaurante.CategoriaSet.OfType<CategoriaSet>().ToList();
            comboBoxCategoriaAlterar.DataSource = meuRestaurante.CategoriaSet.OfType<CategoriaSet>().ToList();
        }

        private void listBoxItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemMenuSet itemMenu = (ItemMenuSet)listBoxItens.SelectedItem;
            comboBoxCategoria.SelectedItem = itemMenu.CategoriaSet.Nome;
            textBoxNomeAlterar.Text = itemMenu.Nome;
            textBoxIngredientesAlterar.Text = itemMenu.Ingredientes;
            textBoxPrecoAlterar.Text = itemMenu.Preco.ToString();
            textBoxImageStringAlterar.Text = itemMenu.Fotografia;
            pictureBoxItemAlterar.Image = ConvertBase64ToImage(itemMenu.Fotografia);
            comboBoxEstadoAlterar.SelectedIndex = itemMenu.Ativo ? 0 : 1;
        }
    }
}