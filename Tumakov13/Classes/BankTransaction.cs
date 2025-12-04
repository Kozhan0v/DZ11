using System;
using Tumakov13.Enums;

namespace Tumakov13.Classes
{
    internal class BankTransaction
    {
        private decimal amount;
        private DateTime dataAndTime;
        private TransactionType typeOfTransaction;

        public BankTransaction(decimal amount, TransactionType transactionType)
        {
            this.amount = amount;
            dataAndTime = DateTime.Now;
            typeOfTransaction = transactionType;
        }

        public decimal Amount
        {
            get => amount;
        }

        public DateTime DataAndTime
        {
            get => dataAndTime;
        }

        public TransactionType TypeOfTransaction
        {
            get => typeOfTransaction;
        }

        public override string ToString()
        {
            return $"Сумма: {amount}. Тип операции: {typeOfTransaction}. Дата и время: {dataAndTime}";
        }
    }
}