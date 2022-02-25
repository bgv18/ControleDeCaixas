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

namespace ControleDeCaixas2.Forms
{
    public partial class viewBox : Form
    {

        private string sql = string.Empty;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        public viewBox()
        {
            InitializeComponent();
            sql = "select * from caixa";
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con.conectar()))
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
            Close();
        }
        private void dataGridView_caixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}