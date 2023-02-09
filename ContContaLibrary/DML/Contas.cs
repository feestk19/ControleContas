using System;
using ControleDeContas.Entities.Enums;

namespace ContContaLibrary.DML
{
    public class Contas
    {
        public long IdConta { get; set; }
        public String NomeConta { get; set; }
        public String DescricaoConta { get; set; }
        public DateTime DtValConta { get; set; }
        public DateTime DtPagConta{ get; set; }
        public TipoConta TipoConta { get; set; }
        public StatusConta StatusConta { get; set; }
    }
}
