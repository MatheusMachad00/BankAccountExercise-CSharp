using BankAccountExercise;
using System;
using System.Globalization;


namespace MyApp {
    internal class Program {

        static void Main(string[] args) {

            Account account;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem vindo ao Banco de Axel!\n", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Digite o número da conta: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do usuário: ");
            string username = Console.ReadLine();

            Console.Write("Haverá um depósito inicial? (s/n) ");
            char initialDeposit = char.Parse(Console.ReadLine());
            if (initialDeposit == 's' || initialDeposit == 'S') {
                Console.Write("Digite o valor do depósito: ");
                double initialDepositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(number, username, initialDepositValue);
            }
            else {
                account = new Account(number, username);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(account.AccountData());

            Console.Write("\nDigite um valor para depósito: ");
            account.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Conta com dados atualizados: ");
            Console.WriteLine(account.AccountData());


            Console.Write("\nDigite um valor para saque: ");
            account.Withdraw(double.Parse(Console.ReadLine()));
            Console.WriteLine("Conta com dados atualizados: ");
            Console.WriteLine(account.AccountData());
        }
    }
}