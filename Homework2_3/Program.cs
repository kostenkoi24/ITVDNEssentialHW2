using System;
using System.Linq;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            
            string[] persons = { "Остап Бендер", "Фелікс Кац", "Шура Балаганов" }; //робітники
            string[] positions = { "Директор", "Бухгалтер", "Охоронець" }; //посади
            int[] salarys_gross = { 10000, 8000, 3000 }; //ЗП
            int[] expiriens = { 5, 3, 1 }; //стаж


            
            for (int i = 0; i < persons.Length; i++)
            {
                string[] fullname = persons[i].Split(new char[] { ' ' });
                Employee employee = new Employee(fullname[0],fullname[1]);
                employee.person = persons[i];
                employee.position = positions[i];
                employee.positionPriority = i; //пріорітет посади для розрахунку коєфіцієнта податку
                employee.salary = salarys_gross[i];
                employee.expiriens = expiriens[i];

                
                employee.CalculateSalary(employee);
            }

            

            Console.ReadKey();

        }
    }
}
