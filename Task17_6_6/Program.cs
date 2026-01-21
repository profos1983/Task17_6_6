using Task17_6_6.Classes;
using Task17_6_6.Interfaces;

var accountsForCountInterest = new List<IAccount>();
var regularAcc1 = new RegularAccount { Balance = 2000 };
var regularAcc2 = new RegularAccount { Balance = 100 };
var salaryAcc1 = new SalaryАccount { Balance = 3000 };
var salaryAcc2 = new SalaryАccount { Balance = 100 };
var salaryAcc3 = new SalaryАccount { Balance = 400 };

accountsForCountInterest.Add(regularAcc1);
accountsForCountInterest.Add(regularAcc2);
accountsForCountInterest.Add(salaryAcc1);
accountsForCountInterest.Add(salaryAcc2);
accountsForCountInterest.Add(salaryAcc3);


foreach (var account in accountsForCountInterest)
{
    Console.Write("Баланс: " + account.Balance);
    Console.Write(" Проценты до расчета: " + account.Interest);
    account.CalculateInterest();
    Console.Write("; Проценты после расчета: " + account.Interest);
    Console.Write(" Ставка: " + account.Interest / account.Balance *100);
    Console.WriteLine();
}


