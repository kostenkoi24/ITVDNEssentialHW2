using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2_3
{

   

    class Employee
    {

        string name;
        string surename;
        public string person;
        public string position;
        public int salary, expiriens, positionPriority;


        
        public Employee(string name, string surename)
        {
            this.name = name;
            this.surename = surename;
        }

        
        public void CalculateSalary(Employee employee)
        {
            Console.WriteLine("ПІБ: {0} {1}",employee.name, employee.surename);

            double koefPercent = 0;
            if (employee.positionPriority == 1)
            {
                koefPercent = 0.3;
            }
            else if (employee.positionPriority == 2)
            {
                koefPercent = 0.2;
            }
            else 
            {
                koefPercent = 0.1;
            }


            Console.WriteLine("\tПосада:{0}",employee.position);
            Console.WriteLine("\tСтаж:{0}", employee.expiriens);
            Console.WriteLine("\tОклад нараховано:{0}", employee.salary);
            Console.WriteLine("\tУтримано :{0} ({1:P})", employee.salary*koefPercent, koefPercent);
            Console.WriteLine("\tДо сплати :{0}", employee.salary *(1-koefPercent));
            Console.WriteLine();



        }

    }
}
