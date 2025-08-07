using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> transactions = new List<decimal>();
            Console.WriteLine("Enter at least 20 transaction amounts:");

            while (transactions.Count < 20)
            {
                Console.Write($"{transactions.Count + 1}. ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal amount))
                {
                    transactions.Add(amount);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a decimal value.");
                }
            }
            var highValueTransactions = transactions.Where(t => t > 10000).ToList();
            decimal total = highValueTransactions.Sum();

            Console.WriteLine("\nQualifying Transactions (Amount > 10,000):");

            for (int i = 0; i < highValueTransactions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {highValueTransactions[i]:N2}");
            }
            Console.WriteLine("\nSummary:");
            Console.WriteLine("--------");
            Console.WriteLine($"Number of high-value transactions: {highValueTransactions.Count}");
            Console.WriteLine($"Total amount: {total:N2}");
        }
    }
}
