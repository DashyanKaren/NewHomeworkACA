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

            Console.WriteLine("Please add person type 1) Student 2) Employee   or type Exit to end");
            int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine("Please Write First Name Last Name and age");
            BankClientOperation operation = new BankClientOperation();
            BankLimit bankLimit=new BankLimit();
          //  var temp=Console.ReadLine();
            do
            {

            switch (result)
            {

                case 1:
                    Student student = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                    Console.WriteLine("please give account number");
                    var accnumber = Console.ReadLine();
                    Console.WriteLine($"Please choose currency 1)AMD,2)EUR, 3)USD, 4)Crypto ");
                    int.TryParse(Console.ReadLine(), out int currencyresult);
                    operation.AddCustomerStudent(student);
                    BankAccount bankAccount = new BankAccount( accnumber, (Currency)currencyresult, bankLimit);
                    break;
                case 2:
                    Employee employee = new Employee(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
                    Console.WriteLine("please give account number");
                    var accnumber1 = Console.ReadLine();
                    Console.WriteLine($"Please choose currency 1)AMD,2)EUR, 3)USD, 4)Crypto ");
                    int.TryParse(Console.ReadLine(), out int currencyresult1);
                    BaseAccount baseAccountEmp = new BaseAccount(accnumber1, (Currency)currencyresult1);
                    BankAccount bankAccount1 = new BankAccount(accnumber1, (Currency)currencyresult1, bankLimit);
                    operation.AddCustomerEmployee(employee);
                    break;

                default: break;
            }
            }
            while (Console.ReadLine() != "exit");
            Console.Write("Please enter Accountnumber=> ");
            //var accnum=Console.ReadLine();
            //Console.WriteLine("What do You wanna do 1)Deposit 2)Withdraw 3) Transfer 4)Check balance");
            //int.TryParse(Console.ReadLine(), out int oper);
            //switch (oper)
            //{
            //    case 1:
                    
            //        break;
            //    case 2: break;
            //    case 3: break;
            //    case 4: break;
            //}


        }
    }
}