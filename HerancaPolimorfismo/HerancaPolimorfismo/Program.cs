using System;
using System.Collections.Generic;
using HerancaPolimorfismo.Entities;
using System.Globalization;
using HerancaPolimorfismo.Entities.Enums;


namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* upcasting é quando uma instância de uma classe derivada é tratada como uma instância da classe base.
              Isso é feito automaticamente pelo compilador em C# e não requer nenhuma conversão explícita.
              Por exemplo, se você tiver uma classe `BusinessAccount` que herda de `Account`,
              você pode atribuir um objeto `BusinessAccount` a uma variável do tipo `Account`
              sem precisar fazer nada especial.*/

            // primeiraAula();
            // upcastingDowncasting();
            // sobreposicao(); // é quando um método da classe base é sobrescrito na classe derivada, permitindo que a classe derivada forneça uma implementação específica do método.
            // exercicioSobreposicao();
            // exercicioFixaxaoConteudo();
            // classeAbstrata();
            metodoAbstrato();

        }

        private static void metodoAbstrato()
        {
            List<Shape> list = new List<Shape>(); // sempre cria com o tipo generico Shape, que é a classe base

            Console.Write("Entre com a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Figura #{i} data:");
                Console.Write("Retangulo ou Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Qual a cor (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Altura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Largura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        private static void classeAbstrata()
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance; // soma os saldos de todas as contas
            }
            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0); // chama o método Withdraw de cada conta
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        private static void exercicioFixaxaoConteudo()
        {
            List<Product> list = new List<Product>();
            Console.Write("Entre com a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Produto {i} + data: ");
                Console.Write("O Produto é novo usado ou importado (n/u/i): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.WriteLine("Taxa de importação: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'n' || ch == 'N')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Digite a data de fabricação (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.WriteLine("Opção invalida, tente novamente!");
                    return;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Etiquetas de preço: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }

        private static void exercicioSobreposicao()
        {
            List<Employee> list = new List<Employee>(); // iniciando a lista
            Console.WriteLine("Digite a quantidade de empregados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado #{i} data:");
                Console.Write("Ele é terceirizado? (y/n): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' || ch == 'Y') // se for terceirizado
                {
                    Console.Write("Valor adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge)); // adiciona o empregado terceirizado na lista
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour)); // adiciona o empregado normal na lista
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Employee emp in list) // percorre a lista de empregados
            {
                Console.WriteLine(emp.Name + " - $ " + emp.payment().ToString("F2", CultureInfo.InvariantCulture)); // imprime o nome e o pagamento de cada empregado
            }
        }

        private static void sobreposicao()
        {
            //Account acc1 = new Account(1001, "Alex", 500.0); // a classe Account é abstrata, então não podemos instanciar ela diretamente
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            //Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }

        private static void upcastingDowncasting()
        {
            // Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); // Fazer uma superclasse chamar a subclasse
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); // mesmo esquema de cima

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount) // verifica se a acc3 é da businessaccount
            {
                BusinessAccount acc5 = acc3 as BusinessAccount; // sintaxe alternativa para downcasting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }

        private static void primeiraAula()
        {
            BusinessAccount account = new BusinessAccount(1001, "Alex", 500.0, 400.0);
            Console.WriteLine(account.Balance);
        }
    }
}
