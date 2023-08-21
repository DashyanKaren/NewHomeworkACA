using OOP.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Bank
{
    

    internal class BankClientOperation
    {
        private static List<Student> students;
        private static List<Employee> employees;


        public BankClientOperation()
        {
               
        }
        
        public void AddCustomerStudent(Student student )
        {
            students.Add(student);
        }
        public void  AddCustomerEmployee(Employee employee)
        {
            employees.Add(employee);    
        } 
        
    }
}
