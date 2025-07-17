using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class NovoProduto
    {
        private string _nome;
        private double _preco;
        public int Quantidade { get; private set; }

        public NovoProduto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }


        public String Nome { 
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


       /* Metodo pouco usado get e set
        * public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
       */

        public double Preco
        {
            get { return _preco; }
        }
       /* public double GetPreco()
        {
            return _preco;
        }
       */

        public double ValorTotalEmEstoque()
        {
            return _preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }

















    }
}
