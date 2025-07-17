using orientacaoObjetos;
using System;
using System.Globalization;

namespace orientacaoObjestos
{
    class Program
    {
        static void Main(string[] args)
        {
            // trianguloSemOrientacaoObjetos();
            // trianguloComOrientacaoObjestos();
            // exercicio01();
            // exercicio02();
            // estoque();
            // exercicioFixacao();
            // membrosEstaticos();
            // exercicioEstatico();
        }

        private static void exercicioEstatico()
        {
            Console.WriteLine("Qual é a cotação do dólar?: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.CalcularDolar(cotacao, quantia);
            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }

        private static void membrosEstaticos()
        {

            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

        private static void exercicioFixacao()
        {
            Retangulo l, a;
            l = new Retangulo();
            
            Console.Write("Entre com a largura do retângulo ");
            l.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com a altura do retângulo: ");
            l.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + l.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + l.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + l.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }

        private static void estoque()
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write ("Quantidade no estoque: ");
            p.Quantidade = int.Parse (Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }

        private static void exercicio02()
        {
            Funcionarios funcionario1, funcionario2;
            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();
            Console.WriteLine("Digite o nome do primeiro funcionário: ");
            funcionario1.A = Console.ReadLine();
            Console.WriteLine("Digite o salário do primeiro funcionário: ");
            funcionario1.B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            funcionario2.A = Console.ReadLine();
            Console.WriteLine("Digite o salário do segundo funcionário: ");
            funcionario2.B = double.Parse(Console.ReadLine());

            double mediaSalario = (funcionario1.B + funcionario2.B) / 2;

            Console.WriteLine("Salário médio: " + mediaSalario);
        }

        private static void exercicio01()
        {
            Alunos aluno1, aluno2;
            aluno1 = new Alunos();
            aluno2 = new Alunos();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            aluno1.A = (Console.ReadLine());
            Console.WriteLine("Digite a idade da primeira pessoa:");
            aluno1.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            aluno2.A = (Console.ReadLine());
            Console.WriteLine("Digite a idade da segunda pessoa:");
            aluno2.B = int.Parse(Console.ReadLine());

            if (aluno1.B > aluno2.B)
            {
                Console.WriteLine("Pessoa mais velha: " + aluno1.A);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + aluno2.A);

            }

        }

        private static void trianguloComOrientacaoObjestos()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        private static void trianguloSemOrientacaoObjetos()
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
            ;
        }
    }
}