using System;

namespace ContContaLibrary.DML
{
    //Classe que irá representar o registro na tabela CONTA no banco de dados
    public class Conta
    {
        public int CodConta { get; set; }
        public int TipoConta { get; set; }
        public DateTime DataValConta { get; set; }
        public float ValorConta { get; set; }



    }
}
