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

namespace Componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();

        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbListaNomes.Items.Add(txtNome.Text);
                txtNome.Clear();
                txtNome.Focus();

            }
        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputador.Checked)
            {
                ltbListarProdutos.Items.Add("Computador");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltbListarProdutos.Items.Add("Mesa");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("Banana");
            }
            else
            {
                ltbListarProdutos.Items.RemoveAt(0);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string origemCompleto = "";
            string foto = "";
            string pastaDestino = "";
            string destinoCompleto = "";

            if (ofdCarregar.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = ofdCarregar.FileName;
                foto = ofdCarregar.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?",
                    "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pcbImagens.ImageLocation = destinoCompleto;
                    MessageBox.Show(destinoCompleto);
                }
                else
                {
                    MessageBox.Show("Arquivo não copiado.");
                }

            }

        }

    }
}