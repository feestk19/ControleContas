using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContContaLibrary.DML;
using System.Data.SqlClient;
using System.Data;
using ControleDeContas.Entities.Enums;

namespace ContContaLibrary.DAL.Contas
    //Classe que irá realizar o acesso a dados da tabela de Contas
{
    internal class DaoContas : Conexao
    {
        //Incluir nova conta
        internal long IncluirComParametro(DML.Contas contas)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("Nome da Conta", contas.NomeConta));
            parametros.Add(new SqlParameter("Descrição da Conta", contas.DescricaoConta));
            parametros.Add(new SqlParameter("Data de Vencimento", contas.DtValConta));
            parametros.Add(new SqlParameter("Tipo da Conta", contas.TipoConta));
            parametros.Add(new SqlParameter("Status da Conta", contas.StatusConta));
            parametros.Add(new SqlParameter("Data de Pagamento", contas.DtPagConta));
            parametros.Add(new SqlParameter("Valor da Conta", contas.ValorConta));

            DataSet ds = Consultar("ADICIONA_CONTAS", parametros);
            long ret = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                long.TryParse(ds.Tables[0].Rows[0][0].ToString(), out ret);
            }

            return ret;
        }

        internal DML.Contas Consultar(long Id)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("ID", Id));

            DataSet ds = Consultar("CONSULTA_CONTAS", parametros);
            List<DML.Contas> ct = Converter(ds);

            return ct.FirstOrDefault();
        }




        private List<DML.Contas> Converter(DataSet ds)
        {
            List<DML.Contas> lista = new List<DML.Contas>();
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DML.Contas con = new DML.Contas();
                    con.IdConta = row.Field<long>("ID");
                    con.NomeConta = row.Field<String>("Nome da Conta");
                    con.DescricaoConta = row.Field<String>("Descrição da Conta");
                    con.DtValConta = row.Field<DateTime>("Data de Vencimento");
                    con.TipoConta = row.Field<TipoConta>("Tipo");
                    con.StatusConta = row.Field<StatusConta>("Status");
                    con.DtPagConta = row.Field<DateTime>("Data de Pagamento");
                    con.ValorConta = row.Field<Double>("Valor");
                    lista.Add(con);
                }
            }

            return lista;
        }
    }
}
