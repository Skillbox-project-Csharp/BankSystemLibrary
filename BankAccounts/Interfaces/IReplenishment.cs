using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary.BankSystem.BankAccounts
{
    public interface IReplenishment<out T> where T : BankAccount
    {

         T Replenishment(double value);
    }
}
