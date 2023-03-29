using BankSystemLibrary.BankSystem.BankAccounts;
using BankSystemLibrary.BankWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary.BankSystem.Documents
{
    public static class DocumentBildHelper
    {
        public static string GetWorkerInfo(Worker worker)
        {
            StringBuilder workerInfoBild = new StringBuilder();
            workerInfoBild.Append(worker.GetType().Name);
            workerInfoBild.Append(":");
            workerInfoBild.AppendLine();
            workerInfoBild.Append("\t");
            workerInfoBild.AppendLine(worker.Name);
            workerInfoBild.Append("\t");
            workerInfoBild.AppendLine(worker.SurName);
            workerInfoBild.Append("\t");
            workerInfoBild.AppendLine(worker.Patronymic);
            return workerInfoBild.ToString();
        }
        public static string GetAccountInfo(BankAccount bankAccount)
        {
            StringBuilder bankAccountInfoBild = new StringBuilder();
            bankAccountInfoBild.Append(bankAccount.GetType().Name);
            bankAccountInfoBild.AppendLine(":");
            bankAccountInfoBild.Append("\t");
            bankAccountInfoBild.Append(bankAccount.Id);
            bankAccountInfoBild.AppendLine();
            bankAccountInfoBild.Append("\t");
            bankAccountInfoBild.Append(bankAccount.Money);
            bankAccountInfoBild.AppendLine();
            return bankAccountInfoBild.ToString();
        }
        public static string GetCientInfo(Client client)
        {
            StringBuilder clientInfoBild = new StringBuilder();
            clientInfoBild.AppendLine(client.Name);
            clientInfoBild.AppendLine(client.SurName);
            clientInfoBild.AppendLine(client.Patronymic);
            return clientInfoBild.ToString();
        }
    }
}
