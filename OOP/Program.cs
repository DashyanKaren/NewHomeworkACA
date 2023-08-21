using OOP.Bank;
using OOP.Person;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankLimit bankLimit=new BankLimit();
         
            do
            {
                Console.WriteLine("Please add person type 1) Student 2) Employee   or type Start to start operation between clients");
                int.TryParse(Console.ReadLine(), out int result);
                Console.WriteLine("Please Write First Name Last Name and age");

                switch (result)
            {

                case 1:
                    Student student = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                    Console.WriteLine("please give account number");
                    var accnumber = Console.ReadLine();
                    Console.WriteLine($"Please choose currency 1)AMD,2)EUR, 3)USD, 4)Crypto ");
                    int.TryParse(Console.ReadLine(), out int currencyresult);
                    student.AddCustomerStudent(student);
                    BankAccount bankAccount = new BankAccount( accnumber, (Currency)currencyresult, bankLimit);
                   bankAccount.AddaToBank(bankAccount);
                        break;
                case 2:
                    Employee employee = new Employee(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                    Console.WriteLine("please give account number");
                    var accnumber1 = Console.ReadLine();
                    Console.WriteLine($"Please choose currency 1)AMD,2)EUR, 3)USD, 4)Crypto ");
                    int.TryParse(Console.ReadLine(), out int currencyresult1);
                    BaseAccount baseAccountEmp = new BaseAccount(accnumber1, (Currency)currencyresult1);
                    BankAccount bankAccount1 = new BankAccount(accnumber1, (Currency)currencyresult1, bankLimit);
                    employee.AddCustomerEmployee(employee);
                    bankAccount1.AddaToBank(bankAccount1);
                    break;

                default: break;
            }
            }
            while (Console.ReadLine() != "start");
            do
            {

            
            Console.Write("Please enter Accountnumber => ");
            var accnum = Console.ReadLine();
            Console.WriteLine($"Please choose currency 1)AMD,2)EUR, 3)USD, 4)Crypto ");
            int.TryParse(Console.ReadLine(), out int curr);
            Console.WriteLine("What do You wanna do 1)Deposit 2)Withdraw 3)Check balance 4)Transfer or type exit to end");
            int.TryParse(Console.ReadLine(), out int oper);
            BaseAccount baseAccount = new BaseAccount(accnum, (Currency)curr);
            switch (oper)
            {
                case 1:
                    
                    Console.WriteLine("Please enter the desired amount =>");
                    double.TryParse(Console.ReadLine(), out double ammount);
                    baseAccount.DoDeposit(ammount);
                    break;
                case 2:
                    Console.WriteLine("Please enter the desired amount =>");
                    double.TryParse(Console.ReadLine(), out double ammount1);
                    baseAccount.DoWithdrawal(ammount1);
                    break;
                case 3:
                        Console.WriteLine(baseAccount.ToString());
                    break;
                case 4:
                        
                        break;
            }
            }
            while (Console.ReadLine()!="exit");


        }
    }
}