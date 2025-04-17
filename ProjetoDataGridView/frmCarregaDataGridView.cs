using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoDataGridView
{
    public partial class frmCarregaDataGridView : Form
    {
        public frmCarregaDataGridView()
        {
            InitializeComponent();
        }

        private void btnCarregaGridView_Click(object sender, EventArgs e)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from  tbfuncionarios;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dgvDados.DataSource = dataTable;

            Conexao.fecharConexao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDados.RowCount; i++)
            {
                dgvDados.Rows[i].DataGridView.Columns.Clear();
            }
        }
    }
}
