using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Please deposit a positive amount.");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Deposit of {amount:C} successful.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", 500);

            Console.WriteLine($"Initial Balance: {account.Balance:C}");

            Console.WriteLine("\nEnter deposit amount:");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
            {
                account.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid deposit amount.");
            }
          
            Console.WriteLine($"Updated Balance: {account.Balance:C}");

            Console.ReadKey();
        }
    }
}
