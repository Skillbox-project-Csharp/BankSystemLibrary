using BankSystemLibrary.BankSystem;
using BankSystemLibrary.BankSystem.BankAccounts;
using BankSystemLibrary.BankSystem.BankWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary.BankWorkers
{
    public class Consultant : Worker
    {
        public override event Action<Worker, bool, object, object, bool> OpenCloseBankAccountEvent;
        public override event Action<Worker, object, object, object, object, object, bool> MoneyTransferEvent;
        public override event Action<Worker, object, object, object, bool> ReplenishmentAccountEvent;

        public Consultant(string name, string surName, string patronymic)
        {
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
        }

        public override bool CloseBankAccount<T>(Client client, T bankAccount)
        {
            bool statusOperation = Bank.CloseBankAccount(client, bankAccount);
            OpenCloseBankAccountEvent?.Invoke(this,false,client, bankAccount, statusOperation);
            return statusOperation;
        }

        public override bool OpenNewBankAccount<T>(Client client, T bankAccount)
        {
            bool statusOperation = Bank.OpenNewBankAccount(client, bankAccount);
            OpenCloseBankAccountEvent?.Invoke(this,true, client, bankAccount, statusOperation);
            return statusOperation;
        }
        public override bool MoneyTransfer<T, M>(Client sender, T senderAccount, Client recipient, M recipientAccount, double value)
        {
            MoneyTransferEvent?.Invoke(this, sender, senderAccount, recipient, recipientAccount, value, false);
            throw new AccessRightsException("Отсутствует доступ к операции перевода");
        }

        public override bool MoneyTransferCov(Client sender, BankAccount senderAccount, Client recipient, BankAccount recipientAccount, double value)
        {
            MoneyTransferEvent?.Invoke(this, sender, senderAccount, recipient, recipientAccount, value, false);
            throw new AccessRightsException("Отсутствует доступ к операции перевода");
        }

        public override bool ReplenishmentByTypeAccount(Client client, Type type, double value)
        {
            ReplenishmentAccountEvent?.Invoke(this, client, type, value, false);
            throw new AccessRightsException("Отсутствует доступ к операции пополнения средсв");
        }
    }
}
