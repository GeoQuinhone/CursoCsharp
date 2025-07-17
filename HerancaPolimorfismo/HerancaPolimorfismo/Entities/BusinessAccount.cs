using System;
using System.Collections.Generic;

namespace HerancaPolimorfismo.Entities
{
     class BusinessAccount : Account // fazendo herança de Account com os :
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) // chamando o construtor da classe base Account
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;  // adiciona o valor do empréstimo ao saldo somente na subclasse BusinessAccount tem acesso
            }
            else
            {
                Console.WriteLine("Sem limite");
            }
        }
    }
}
