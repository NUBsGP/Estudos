﻿using System.Globalization;

namespace Aula51
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Preco = 5;
            Quantidade = 10;
        }

        public Produto(string nome, double preco, int quantidade)   //            //
        {                                                          // CONSTRUTOR //
            Nome = nome;                                          //            //
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)   //            // 
        {                                          // SOBRECARGA //
            Nome = nome;                          //            //
            Preco = preco;
        }
        public Produto(string nome) : this()                 //                                                      //
        {                                                   // TEST COM THIS (REFERENCIANDO UM CONSTRUTOR EM OUTRO) //
            Nome = nome;                                   //                                                      //
        }

        public double ValorTotalEmEstoque()   //                                 //
        {                                    // PARAMETRO QUE NÃO RETORNA VALOR //
            return Preco * Quantidade;      //                                 //
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()   //            //
        {                                  // FORMATAÇÃO //
            return Nome                   //            //
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}