using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace login_e_cadastro
{
    public class conexao
    {
        SqlConnection con = new SqlConnection();
        //construtor
        public conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-R18EQOH\SQLEXPRESS02;Initial Catalog=Testes;Integrated Security=True";
        }
        //conectar banco de dados
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //deconectar banco de dados
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
