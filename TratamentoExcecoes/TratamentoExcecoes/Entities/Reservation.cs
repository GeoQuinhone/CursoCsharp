using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TratamentoExcecoes.Entities.Exceptions;

namespace TratamentoExcecoes.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Checkout tem que ser posterior a data de Checkin"); // Verifica se CheckOut é posterior a CheckIn
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn); // Calcula a diferença entre CheckOut e CheckIn
            return (int)duration.TotalDays; // Retorna a duração em dias
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {

            DateTime now = DateTime.Now; // Obtém a data e hora atual
            if (checkIn < now || checkOut <= checkIn)
            {
                // return é usado no exercicioerrado 2
                throw new DomainException ("Check-in deve ser uma data futura e Check-out deve ser posterior ao Check-in.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException ("Checkout tem que ser posterior a data de Checkin"); // Verifica se CheckOut é posterior a CheckIn
            }
            CheckIn = checkIn;
            CheckOut = checkOut;         
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration() 
                + " noites ";
;
        }
    }
}
