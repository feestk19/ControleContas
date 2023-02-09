using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ContContaLibrary.DAL
{
    internal class Conexao
    {
        private string stringConexao
        {
            get
            {
                //Verifica e da um get na string de conexão do banco de dados interno passando como parâmetro o BD BancoDeDados
                ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["BancoDeDados"];
                if (conn != null)
                {
                    return conn.ConnectionString;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        internal void Executar(string NomeProcedure, List<SqlParameter> parametros)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexao = new SqlConnection(stringConexao);
            cmd.Connection = conexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NomeProcedure;
            foreach (var item in parametros)
            {
                cmd.Parameters.Add(item);
            }

            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }

        internal DataSet Consultar(string NomeProcedure, List<SqlParameter> parametros)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexao = new SqlConnection(stringConexao);//Inicia a conexão passando a string de conexão

            cmd.Connection = conexao;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NomeProcedure;
            foreach (var item in parametros)
            {
                cmd.Parameters.Add(item);
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conexao.Open();

            try
            {
                adapter.Fill(ds);
            }
            finally
            {
                conexao.Close();
            }

            return ds;
        }




    }
}
