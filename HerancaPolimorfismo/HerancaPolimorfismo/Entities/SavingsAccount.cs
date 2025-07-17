using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    sealed class SavingsAccount : Account // o sealed impede que outras classes herdem de SavingsAccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) 
 // o sealed impede que outras classes herdem de SavingsAccount e sobrescrevam o método Withdraw
  // usamos o override para sobrescrever o método Withdraw da classe base Account
        {
            base.Withdraw(amount); // chama o método Withdraw da classe base
            Balance -= 2.0; // adiciona uma taxa de 2.0 ao saque
        }
    }
}
