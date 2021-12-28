using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_e_cadastro
{
    public class cadastro
    {
        SqlCommand cmd = new SqlCommand();
        conexao conexao = new conexao();
        public string mensagem;
        public cadastro(string nome, string telefone)
        {
            //comando sql
            cmd.CommandText = "insert into cadastro (nome, telefone) values (@nome, @telefone)";
            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            //conectar com banco
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();

                //desconectar
                conexao.desconectar();

                //mensaem erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!";
            }
            catch (SqlException ex)
            {
                //mensaem erro ou sucesso
                this.mensagem = "Erro ao tentar se conectar ao banco de dados!";
            }
            
            
            
        }
    }
}
