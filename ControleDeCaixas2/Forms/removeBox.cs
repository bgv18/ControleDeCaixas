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
    public partial class removeBox : Form
    {
        SqlConnection conexao = null;
        private string con = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Caixa;Data Source=GUERRA\SQLEXPRESS";
        private string sql = string.Empty;
        public removeBox()
        {
            InitializeComponent();
            tb_id.Enabled = false;
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
                        dataGridView_remove.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_remove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sql = @"delete from caixa where id = @id";
            conexao = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_id.Text;
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Caixa deletada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
            }
        }
    }
}
