using System;
using System.Globalization;

namespace POO
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public void AumentarPreco(double percentual)
        {
            Preco += Preco * percentual / 100.00;
        }
        public void ReduzirPreco(double percentual)
        {
            Preco -= Preco * percentual / 100.00;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
