using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = -100; //SByte funcionaria tambem

            Console.WriteLine(x);

            bool completo = false;
            char genero = 'F'; // char aspas simples ''
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Geovane Quinhone"; // string aspas duplas ""
            object obj1 = "Alex Brown";
            object obj2 = 4.5;
            int min = int.MinValue;
            int max = int.MaxValue;
            sbyte min2 = sbyte.MinValue;
            decimal max3 = decimal.MaxValue;


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);  
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(min2);
            Console.WriteLine(max3);

            Console.Write("Bom diaa!");
            Console.WriteLine("Boa tarde!"); // faz a quebra de linha
            Console.WriteLine("Boa noite!");

            double saldo = 10.35784;
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // imprimir com o . inves da ,

            Console.WriteLine("--------------------------------------------");

            int idade = 32;
            double saldo2 = 10.38548;
            string nome2 = "Geovane";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade, saldo2); // placehoders

            Console.WriteLine($"{nome2} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação

            Console.WriteLine(nome2 + " tem "+ idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // concatenação

            // exercicios();
            // operadoresDeAtribuicao();
            // castingConversao();
            // operadoresAritméticos();
            // entradaDeDados();
            // operadoresComparativos();
            // operadoresLogicos();
            // operadorCondicional();
            // estruturaWhile();
            // estruturaFor();
        }

        private static void estruturaFor()
        {
            Console.Write("Quantos números inteiros você vai digitar?: ");
            int NN = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= NN; i++)
            {
                Console.WriteLine(i);
            }

        }

        private static void estruturaWhile()
        {
            
                Console.WriteLine("Digite um numero inteiro: ");
                double ni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (ni >= 0.0)
            {
                double raiz = Math.Sqrt(ni);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                ni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");
        }

        private static void operadorCondicional()
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int xx1 = int.Parse(Console.ReadLine());

            if (xx1 % 2 == 0)
            {
                Console.WriteLine("Par!");

            } else
            {
                Console.WriteLine("Impar!");
            }
            }

        private static void operadoresLogicos()
                {
                    bool opl1 = 2 > 3 && 4 != 5; // true
                    Console.WriteLine(opl1);

                    bool opl2 = 2 > 3 || 4 != 5;
                    Console.WriteLine(opl2);

                    bool opl3 = !(2 > 3) && 4 != 5;  // true
                    Console.WriteLine(opl3);

                    bool opl4 = 10 < 5;

                    bool opl5 = opl2 || opl3 && opl4; // true
                    Console.WriteLine(opl5);
                }

        private static void operadoresComparativos()
        {
            int ap = 10;
            bool cond1 = ap < 10;
            bool cond2 = ap < 20;
            bool cond3 = ap > 10;
            bool cond4 = ap > 5;
            Console.WriteLine(cond1);
            Console.WriteLine(cond2);
            Console.WriteLine(cond3);
            Console.WriteLine(cond4);
            Console.WriteLine("------------------------");
            bool cond5 = ap <= 10;
            bool cond6 = ap >= 20;
            bool cond7 = ap == 10;
            bool cond8 = ap != 10;
            Console.WriteLine(cond5);
            Console.WriteLine(cond6);
            Console.WriteLine(cond7);
            Console.WriteLine(cond8);
        }

        private static void entradaDeDados()
        {
            Console.WriteLine("");
            Console.WriteLine("Entrada de Dados");
            Console.WriteLine("Digite uma palavra");
            string frase = Console.ReadLine();
            Console.WriteLine("Você digitou: " + frase);

            Console.WriteLine("Digite 3 palavras");
            string[] vetor = Console.ReadLine().Split(' ');
            string a1 = vetor[0];
            string b2 = vetor[1];
            string c3 = vetor[2];
            Console.WriteLine(a1);
            Console.WriteLine(b2);
            Console.WriteLine(c3);

            Console.WriteLine("Digite um numero: ");
            int nnn1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + nnn1);

            Console.WriteLine("Digite F ou M");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);

            Console.WriteLine("Digite um numero double");
            double nnn2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(nnn2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite seu nome, sexo(M ou F), idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nomme = vet[0];
            char sexxo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nomme);
            Console.WriteLine(sexxo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            Console.WriteLine(" ");
            Console.WriteLine("Exercicio proposto");

            Console.WriteLine("Digite o seu nome completo: ");
            string nomeAtividade = Console.ReadLine();
            Console.WriteLine("Quantos Quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (digite na mesma linha) : ");
            String[] vett = Console.ReadLine().Split(' ');
            string ulNome = vett[0];
            int nIdade = int.Parse(vett[1]);
            double nAltura = double.Parse(vett[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nomeAtividade);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ulNome);
            Console.WriteLine(nIdade);
            Console.WriteLine(nAltura.ToString("F2", CultureInfo.InvariantCulture));
            
        }

        private static void operadoresAritméticos()
        {
            Console.WriteLine("");
            Console.WriteLine("Operadores Aritméticos");

            int nn1 = 3 + 4 * 2;
            int nn2 = (3 + 4) * 2;
            int nn3 = 17 % 3;
            double nn4 = (double) 10 / 8; // posso colocar tambem double nn4 = 10.0 / 8 sem o casting
            Console.WriteLine(nn1);
            Console.WriteLine(nn2);
            Console.WriteLine(nn3);
            Console.WriteLine(nn4);
        }

        private static void castingConversao()
        {
            Console.WriteLine("");
            Console.WriteLine("Casting Conversao");
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);

            double yx; 
            float xy;
            yx = 5.1;
            xy = (float)yx; // quando o tipo for superior ao que queremos trocar fazer a declaração (int) por exepmlo se for int
            Console.WriteLine(xy);

            int xx = 5;
            int yy = 2;
            double resultado = (double)xx / yy;
            Console.WriteLine(resultado);

        }

        private static void operadoresDeAtribuicao()
        {
            Console.WriteLine("");
            Console.WriteLine("Operadores de Atribuição");
            int z = 10;
            Console.WriteLine(z);

            z += 2;
            Console.WriteLine(z);

            z *= 3;
            Console.WriteLine(z);
        }

        static void exercicios ()
        {
            Console.WriteLine("");
            Console.WriteLine("Exercicios");
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte novaIdade = 30;
            int codigo = 5290;
            char novoGenero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {novaIdade} anos de idade, código {codigo} e gênero: {novoGenero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}

