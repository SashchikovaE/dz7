using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    internal class Bank
    {
        public long number;
        public double balance;
        public Type type;
        public void SetNumber(long number)
        {
            this.number = number;
        }
        public long GetNumber()
        {
            return number;
        }
        public void SetBalance(double balance)
        {
            this.balance += balance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetType(Type type)
        {
            this.type = type;
        }
        public Type GetType(Type type)
        {
            return type;
        }
        public void AddSum(double sum)
        {
            if (sum >= 0)
            {
                balance += sum;
            }

        }
        public static void TransferMoney(Bank fromAccount, Bank account2, double amount)
        {
            if (amount <= fromAccount.balance)
            {
                fromAccount.balance -= amount;
                account2.balance += amount;
                Console.WriteLine($"перевод в размере {amount} успешно выполнен");
            }
            else
            {
                Console.WriteLine("недостаточно средств на счете");
            }
        }
    }
}