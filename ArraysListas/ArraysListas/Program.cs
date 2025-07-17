using System;
using System.Numerics;
using System.Globalization;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {

            //   primeiraAula();
            //   aulaNullable();
            //   aulaVetores();
            //   aulaVetores2();
            //   exercicioFixaxao();
            //   modificadorParams();
            //   sintaxeForeach();
            //   aulaListas();
            //   aulaListas2();
            //   matrizes();
            exercicioMatriz();
        }

        private static void exercicioMatriz()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Maind diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " "); // Imprime os elementos da diagonal principal
            }
            Console.WriteLine();

            int count = 0; // Contador para elementos negativos
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] <0) // Verifica se o elemento é negativo
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }

        private static void matrizes()
        {
            double[,] mat = new double[2, 3]; // instancia uma matriz 2x3
            Console.WriteLine(mat.Length); // Imprime o número total de elementos na matriz (6)

            Console.WriteLine(mat.Rank); // Imprime o número de dimensões da matriz (2)

            Console.WriteLine(mat.GetLength(0)); // Imprime o tamanho da primeira dimensão da matriz (2)

            Console.WriteLine(mat.GetLength(1)); // Imprime o tamanho da segunda dimensão da matriz (3)
        }

        private static void aulaListas2()
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); // Insere "Marco" na posição 2 da lista

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); // Imprime o número de elementos na lista

            string s1 = list.Find(x => x[0] == 'A'); // expressão lambda para encontrar o primeiro elemento que começa com 'A'
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // expressão lambda para encontrar o último elemento que começa com 'A'
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // encontra o índice do primeiro elemento que começa com 'A'
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // encontra o ultimo do primeiro elemento que começa com 'A'
            Console.WriteLine("First position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5); // encontra todos os elementos com comprimento igual a 5
            Console.WriteLine("--------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj); // Imprime todos os elementos encontrados com comprimento igual a 5
            }

            list.Remove("Alex"); // Remove o elemento "Alex" da lista
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3); // Remove o elemento na posição 2 da lista
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); // Remove os elementos da posição 2 até a posição 3 (2 elementos)
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // Remove todos os elementos que começam com 'M'
            Console.WriteLine("--------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }

        private static void aulaListas()
        {
            List<string> list = new List<string>(); // Declaração de uma lista de strings vazia
            list.Add("Joaozinho"); // Adiciona um elemento à lista

            List<string> list2 = new List<string> { "Geovane", "Quinhone" }; // Declaração de uma lista de strings com valores iniciais

        }

        private static void sintaxeForeach()
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" }; // Declaração de um vetor de strings

            //Jeito 1 com laço for
            for (int i = 0; i < vect.Length; i++) // Usando for para iterar sobre o vetor
            {
                Console.WriteLine(vect[i]); // Imprime cada elemento do vetor
            }
            Console.WriteLine("-----------------------------------------");
            // Jeito 2 com laço foreach
            foreach (string obj in vect) // Usando foreach para iterar sobre o vetor obj é o apelido
            {
                Console.WriteLine(obj); // Imprime cada elemento do vetor
            }
        }

        private static void modificadorParams()
        {
            int s1 = Calculator.Sum(2, 3); // utilizando o modificador params, podemos simplificar e nao passar as chaves {}
            // O modificador params permite que o método receba um número variável de argumentos

            int s2 = Calculator.Sum(new int[] { 2, 4, 3 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //ref = modificador de parametro
            int a = 10;
            Calculator.triple(ref a); // O modificador ref permite passar uma variável por referência, permitindo que o método modifique seu valor original
            Console.WriteLine(a);

            int b = 10;
            int dobro;
            Calculator.dobro(b, out dobro); // O modificador out permite que o método retorne um valor adicional, além do valor de retorno principal
            Console.WriteLine(dobro);

            // Diferença entre ref e out:
            // A variavel passada com parâmetro ref deve ter sido iniciada
            // a variavel passada com parâmetro out não precisa ser iniciada
        }

        private static void exercicioFixaxao()
        {
            Hotel[] vect = new Hotel[10]; // Declaração de um vetor de Quarto com tamanho 10
            Console.WriteLine("Quantos estudantes vão alugar os quartos?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o número do quarto desejado de 1 a 10: ");
                int quarto = int.Parse(Console.ReadLine());
                if (quarto < 1 || quarto > 10)
                {
                    Console.WriteLine("Número de quarto inválido. Tente novamente.");
                    return;
                }
                else
                {
                    if (vect[quarto - 1] != null) // Verifica se o quarto já está ocupado
                    {
                        Console.WriteLine("Quarto ja ocupado!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Digite o nome do estudante: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o email do estudante: ");
                        string email = Console.ReadLine();
                        vect[quarto - 1] = new Hotel(nome, email, quarto); // Inicializa o quarto com os dados do estudante
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null) // Verifica se o quarto está ocupado
                {
                    Console.WriteLine(vect[i]); // Imprime os dados do estudante que ocupa o quarto
                }
            }


        }

        private static void aulaVetores2()
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n]; // Declaração de um vetor de Product com tamanho n

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price }; // Inicialização do vetor com novos objetos Product
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price; // Soma dos preços dos produtos
            }
            double avg = sum / n; // Cálculo da média dos preços
            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void aulaVetores()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n]; // Declaração de um vetor de double com tamanho n

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura dos valores do vetor
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i]; // Soma dos valores do vetor
            }

            double avg = soma / n; // Cálculo da média

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }

        private static void aulaNullable()
        {
            //  double x = null;  Erro, não é possível atribuir null a um tipo primitivo nao recebe nullable
            Nullable<double> y = null; // Forma alternativa de declarar um tipo nullable
            double? z = 10; // Forma mais comum de declarar um tipo nullable

            Console.WriteLine(y.GetValueOrDefault()); // Retorna 0, pois é o valor padrão de double
            Console.WriteLine(z.GetValueOrDefault()); // Retorna 10, pois é o valor atribuído

            Console.WriteLine(y.HasValue); // Retorna false, pois y é null
            Console.WriteLine(z.HasValue); // Retorna true, pois z tem um valor

            // Console.WriteLine(y.Value);  Lança uma exceção, pois y é null

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            double? a = null;
            double? b = 10;

            double m = a ?? 5; // Se a for null, m recebe 5, caso contrário, m recebe o valor de a
            double n = b ?? 5; // Se b for null, n recebe 5, caso contrário, n recebe o valor de b

            Console.WriteLine(m);
            Console.WriteLine(n);
        }

        private static void primeiraAula()
        {
            Point p; // Não precisa usar 'new' para declarar uma struct, ja que ela é um tipo de valor
            p.X = 10.0;
            p.Y = 20.0;
            Console.WriteLine(p);
            p = new Point(); // Aqui sim, usamos 'new' para inicializar uma struct
            Console.WriteLine(p);
        }
    }
}
