using System;
using System.Globalization;
using TratamentoExcecoes.Entities;
using TratamentoExcecoes.Entities.Exceptions;


namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // tryEcatch();

            // exercicioTryCatchErrado();

            // exercicioTryCatchErrado2();

            exercicioTryCatchCerto();
        }

        private static void exercicioTryCatchCerto()
        {
            try
            {
                Console.Write("Numero do Quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Data de Check-in data (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de Check-out data (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com a data de atualização de reserva: ");
                Console.Write("Data de Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do programa.");

            }
        }



        private static void exercicioTryCatchErrado2()
        {
            Console.Write("Numero do Quarto: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Data de Check-in data (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de Check-out data (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro na reserva: Checkout tem que ser anterior a data de Checkin");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com a data de atualização de reserva: ");
                Console.Write("Data de Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                /* string error = reservation.UpdateDates(checkIn, checkOut);

                if (error != null)
                {
                    Console.WriteLine("Erro na reserva: " + error);
                }
                else
                {
                    Console.WriteLine("Reserva: " + reservation);
                }
                */
                {
                }
            }
        }


        private static void exercicioTryCatchErrado()
        {
            Console.Write("Numero do Quarto: ");
            int roomNumber = int.Parse(Console.ReadLine());

            Console.Write("Data de Check-in data (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de Check-out data (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Erro na reserva: Checkout tem que ser anterior a data de Checkin");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Entre com a data de atualização de reserva: ");
                Console.Write("Data de Check-in data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de Check-out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now; // Obtém a data e hora atual
                if (checkIn < now || checkOut <= checkIn)
                {
                    Console.WriteLine("Erro na reserva: Check-in deve ser uma data futura e Check-out deve ser posterior ao Check-in.");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Erro na reserva: Checkout tem que ser posterior a data de Checkin");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reserva: " + reservation);
                }
                {
                }
            }
        }

        private static void tryEcatch()
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            { // o e é o objeto que contém a exceção

                Console.WriteLine("Divisão por 0 não é permitido");
            }
            catch (FormatException ex) // o ex é o objeto que contém a exceção
            {
                Console.WriteLine("Entrada inválida: " + ex.Message);
            }
            finally
            {
                // Este bloco é sempre executado, independentemente de uma exceção ter ocorrido ou não.
                Console.WriteLine("Fim do programa.");
            }
        }
    }
}