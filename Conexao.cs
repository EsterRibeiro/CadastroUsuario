using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBD
{
    public class Conexao
    {
        //instância de sql conncetion
        SqlConnection sqlConnection = new SqlConnection();

        //Construtor
        public Conexao()
        {
            sqlConnection.ConnectionString = @"Data Source=;Initial Catalog=;Integrated Security=True";
        }
        //Método Conectar
        public SqlConnection Conectar() 
        {
            if(sqlConnection.State == ConnectionState.Closed)          
                sqlConnection.Open();
            
            return sqlConnection;
        }
        //Método Desconectar
        public void Desconectar()
        {
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }
    }
}
