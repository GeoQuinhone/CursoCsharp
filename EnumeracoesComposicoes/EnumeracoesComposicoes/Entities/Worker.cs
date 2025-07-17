using System;
using System.Collections.Generic;
using EnumeracoesComposicoes.Entities.Enums;


namespace EnumeracoesComposicoes.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação entre classes

        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // faz a lista de contratos, ja instanciando a lista

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) // Não passar a lista de contratos, pois ela já é instanciada
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
   
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
    
    
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }







    }
}
