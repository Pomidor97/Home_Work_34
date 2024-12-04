using System;
using System.Collections.Generic;
using HomeWork_34;
using Lesson_33;


Bank<Account> bank = new Bank<Account>();

bank.AddAccount(new DepositAccount(1001, 1500.00m));
bank.AddAccount(new TransitAccount(2002, 500.50m));
bank.AddAccount(new ClosedAccount(3003, 0.00m));

Console.WriteLine("Список всех счетов:");
bank.DisplayAllAccounts();
