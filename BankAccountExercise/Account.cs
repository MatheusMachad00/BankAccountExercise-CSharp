using System.Globalization;

namespace BankAccountExercise {
    internal class Account {

        public int AccountNumber { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string name) {
            AccountNumber = accountNumber;
            Name = name;
        }

        public Account(int accountNumber, string name, double balance) {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
        }

        public void Deposit(double value) {
            Balance += value;
        }

        public void Withdraw(double value) {
            Balance = Balance - (value + 5);
        }
        public string AccountData() {
            return $"Conta: {AccountNumber}, Titular: {Name}, Saldo: R${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
