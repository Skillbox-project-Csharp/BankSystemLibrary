﻿using BankSystemLibrary.BankSystem.BankAccounts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary.BankSystem
{
    public abstract class Client
    {
        protected Guid _Id;
        protected ObservableCollection<BankAccount> _bankAccounts;
        protected string _name;
        protected string _surName;
        protected string _patronymic;
        abstract public Guid Id { get; }
        abstract public string Name { get; set;}
        abstract public string SurName { get; set; }
        abstract public string Patronymic { get; set; }
        abstract public ObservableCollection<BankAccount> BankAccounts { get;}
    }
}
