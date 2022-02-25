using ControleDeCaixas2.Class;
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

namespace ControleDeCaixas2
{
    public partial class updateBox : Form
    {
        private string sql = string.Empty;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public updateBox()
        {
         
            InitializeComponent();
            tb_id.Enabled = false;
            tb_altura.Enabled = false;
            tb_largura.Enabled = false;
            tb_profundidade.Enabled = false;
            tb_quantidade.Enabled = false;
            sql = "select * from caixa";
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con.conectar()))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView_update.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Enabled = true;
            tb_altura.Enabled = true;
            tb_largura.Enabled = true;
            tb_profundidade.Enabled = true;
            tb_quantidade.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sql = @"update caixa set altura = @altura, largura = @largura, profundidade = @profundidade, quantidade = @quantidade where id = @id";
            SqlCommand cmd = new SqlCommand(sql, con.conectar());

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_id.Text;
            cmd.Parameters.Add("@altura", SqlDbType.Float).Value = tb_altura.Text;
            cmd.Parameters.Add("@largura", SqlDbType.Float).Value = tb_largura.Text;
            cmd.Parameters.Add("@profundidade", SqlDbType.Float).Value = tb_profundidade.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = tb_quantidade.Text;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Caixa atualizada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
