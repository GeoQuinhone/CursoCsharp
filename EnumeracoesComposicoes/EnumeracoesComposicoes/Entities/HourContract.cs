using System;


namespace EnumeracoesComposicoes.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValueperHour { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valueperHour, int hours)
        {
            Date = date;
            ValueperHour = valueperHour;
            Hours = hours;
        }

        public double TotalValue()
        { 
            return Hours * ValueperHour;
        }
    }
}
