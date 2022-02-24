using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCaixas2.Forms
{
    public partial class viewBox : Form
    {

        SqlConnection conexao = null;
        private string con = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Caixa;Data Source=GUERRA\SQLEXPRESS";
        private string sql = string.Empty;
        public viewBox()
        {
            InitializeComponent();
            sql = "select * from caixa";
            conexao = new SqlConnection(con);
            try
            {
                conexao.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conexao))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView_caixa.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            conexao.Close();
            Close();
        }
        private void dataGridView_caixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}