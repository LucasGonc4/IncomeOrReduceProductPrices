using System;
using System.Globalization;
using System.Collections.Generic;


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Digite a quantidade de produtos a ser cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o ID do produto: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o preco do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                list.Add(new Produto(id, nome, preco));
            }
            Console.Write("O preco do produto será aumentado ou reduzido (A/R)?: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 'A' || resp == 'a')
            {
                Console.Write("Digite o ID do produto a ter seu preço aumentado: ");
                int searchid = int.Parse(Console.ReadLine());
                Produto prod = list.Find(x => x.Id == searchid);
                if (prod != null)
                {
                    Console.Write("Digite a porcentagem a ser aumentada do valor do produto: ");
                    double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prod.AumentarPreco(percentual);
                }
                else
                {
                    Console.WriteLine("O ID deste produto não existe!");
                }
            }

            else if (resp == 'R' || resp == 'r')
            {
                Console.Write("Digite o ID do produto a ter seu preço reduzido: ");
                int searchid = int.Parse(Console.ReadLine());

                Produto prod = list.Find(x => x.Id == searchid);
                if (prod != null)
                {
                    Console.Write("Digite a porcentagem a ser reduzida do valor do produto: ");
                    double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prod.ReduzirPreco(percentual);
                }
                else
                {
                    Console.WriteLine("O ID deste produto não existe!");
                }


            }
            Console.WriteLine();
            Console.WriteLine("Preco dos produtos atualizados: ");

            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }
        }

    }

}
