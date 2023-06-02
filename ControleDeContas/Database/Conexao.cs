using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace ControleDeContas.Database
{
    internal class Conexao
    {
        //private static string server = @"FSTROMBECK";
        //private static string dataBase = "ControleDeContas";
        //private static string user = "sa";
        //private static string password = "123456";

       

        public string StringConexao()
        {
            return @"Data Source= DESKTOP-V0TGTUS; Integrated Security=False; Initial Catalog= ControleDeContas; User ID= sa; Password=123456";

            //Utilizando concatenação
            //get { return "Data Source=" + server + "; Integrated Security=False; Initial Catalog=" + dataBase + "; User ID=" + user + "; Password=" + password; }

            //Utilizando interpolação
            //get { return $"Data Source={server}; Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }
        }
    }
}
