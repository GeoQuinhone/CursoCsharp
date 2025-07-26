using System;
using System.Globalization;
using InterfaceDois.Devices;
using InterfaceDois.Entities;
using InterfaceDois.Model.Entities;
using InterfaceDois.Model.Entities.Enums;

namespace InterfaceDois
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // InversaoControle();
            // ProblemaDiamante();
            // InterfaceIcomparable();
            InterfaceIcomparableDois();
        }

        private static void InterfaceIcomparableDois()
        {
            string path = @"c:\temp\newIn.txt"; // Caminho do arquivo de entrada

            try
            {
                using (StreamReader sr = File.OpenText(path)) // StreamReader abre o arquivo
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); // Ordena a lista usando o método Sort, que usa IComparable
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp); // Imprime cada item da lista ordenada
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        private static void InterfaceIcomparable()
        {
            string path = @"c:\temp\in.txt"; // Caminho do arquivo de entrada

            try
            {
                using (StreamReader sr = File.OpenText(path)) // StreamReader abre o arquivo
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort(); // Ordena a lista usando o método Sort, que usa IComparable
                    foreach (string str in list)
                    {
                        Console.WriteLine(str); // Imprime cada item da lista ordenada
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }

        private static void ProblemaDiamante()
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My Letter");
            p.Print("My Letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3001 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }

        private static void InversaoControle()
        {
            /* Shape s1 = new Circle() { Radius = 2.0, Color = Color.White }; jeito anterior menos recomendado
             Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2); */

            IShape s3 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s4 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}