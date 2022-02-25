﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCaixas2.Class
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();


        public Conexao()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        
        public void desconectar()
        {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
        }
    }
}
