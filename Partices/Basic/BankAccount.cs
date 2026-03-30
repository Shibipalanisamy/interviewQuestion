using System;
using System.Collections.Generic;
using System.Text;

namespace Partices.Basic
{
    public class BankAccount
    {
        private int currentBalance;

        public int deposite
        {
            get {return  currentBalance;}
            set { currentBalance += value;}
        }
        public BankAccount(int balance)
        {
            currentBalance= balance;
        }
    }
}
