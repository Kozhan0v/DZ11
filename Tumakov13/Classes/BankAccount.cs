using System;
using Tumakov13.Enums;

namespace Tumakov13.Classes
{
    internal class BankAccount
    {
        private static long staticAccountNum = 0;
        private long accountNum;
        private decimal balance;
        private TypeOfBankAccount bankAccountType;
        private string holder;
        private Queue<BankTransaction> transactions = new Queue<BankTransaction>();

        internal BankAccount()
        {
            accountNum = CreateNewAccountNum();
        }

        internal BankAccount(decimal balance)
        {
            accountNum = CreateNewAccountNum();
            this.balance = balance;
        }

        internal BankAccount(TypeOfBankAccount bankAccountType)
        {
            accountNum = CreateNewAccountNum();
            this.bankAccountType = bankAccountType;
        }

        internal BankAccount(decimal balance, TypeOfBankAccount bankAccountType)
        {
            accountNum = CreateNewAccountNum();
            this.balance = balance;
            this.bankAccountType = bankAccountType;
        }

        public long AccountNum
        {
            get => accountNum;
        }

        public decimal Balance
        {
            get => balance;
        }

        public TypeOfBankAccount BankAccountType
        {
            get => bankAccountType;
        }
        public string Holder
        {
            get => holder;
            set => holder = value;
        }

        public BankTransaction this[int index]
        {
            get
            {
                if (index < 0 || index >= transactions.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return transactions.ToArray()[index];
            }
        }

        private long CreateNewAccountNum()
        {
            return ++staticAccountNum;
        }

        public override string ToString()
        {
            return $"Номер счета: {accountNum}. Баланс: {balance}. Тип счета: {bankAccountType}";
        }

        public void PrintTransactions()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Операция невозможна!");
                return;
            }

            balance += amount;

            BankTransaction transaction = new BankTransaction(amount, TransactionType.Deposit);
            transactions.Enqueue(transaction);
        }

        public void Withdrow(decimal amount)
        {
            if (balance < amount && amount < 0)
            {
                Console.WriteLine("Операция невозможна!");
                return;
            }

            balance -= amount;

            BankTransaction transactions = new BankTransaction(amount, TransactionType.Withdrow);
            this.transactions.Enqueue(transactions);
        }

        public void Transfer(BankAccount bankAccount, decimal amount)
        {
            bankAccount.Withdrow(amount);
            Deposit(amount);
        }
    }
}