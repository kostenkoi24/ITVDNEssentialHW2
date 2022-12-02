using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2_6
{
    class User
    {
        public string login, name, surename;
        public int age;
        DateTime date; 

        public User()
        {
                date = DateTime.Now;
        }

        

        public DateTime Date
        {
            get { return date; }
            
        }


        public static void ShowUserInfo(User user)
        {

            Console.WriteLine($"Login: {user.login}");
            Console.WriteLine($"Name: {user.name}");
            Console.WriteLine($"Surename: {user.surename}");
            Console.WriteLine($"Age: {user.age}");
            Console.WriteLine($"Date: {user.Date}");

        }




    }
}
