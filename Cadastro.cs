using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    public class Cadastro
    {
        SqlCommand sqlCommand = new SqlCommand();

        Conexao conexao = new Conexao();

        public string resultado;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Cadastro(string nome, string sobrenome, string email, string senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;

            //Comandos CRUD SQL -- SQLCommand
            sqlCommand.CommandText = "insert into Usuario (Nome, Sobrenome, Email, Senha)" +
                " values (@Nome, @Sobrenome, @Email, @Senha)";

            //parâmetros
            sqlCommand.Parameters.AddWithValue("@Nome", nome);
            sqlCommand.Parameters.AddWithValue("@Sobrenome", sobrenome);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Senha", senha);

            //conectar com o banco
            try
            {
                //abre a conexão com o banco
                sqlCommand.Connection = conexao.Conectar();

                //executa o comando
                sqlCommand.ExecuteNonQuery();

                //desconectar
                conexao.Desconectar();

                //mensagem de erro ou sucesso
                this.resultado = "Cadastrado com sucesso!";
            }
            catch (SqlException) //erro específico com o banco
            {
                this.resultado = "Erro de conexão com o banco";
            }
        }








        //executar comando CRUD
        //desconectar
        //mostrar mensagem de erro ou sucesso

    }
}
