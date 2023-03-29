using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary.BankSystem.BankWorkers
{
    public class AccessRightsException : Exception
    {
        public AccessRightsException(string msg) : base(msg) { }
    }
}
