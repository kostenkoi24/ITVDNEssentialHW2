using System;

namespace Homework2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.login = "user_login";
            user.name = "name";
            user.surename = "surename";
            user.age = 99;


            User.ShowUserInfo(user); //статичний метод для того щоб кожний екземпляр класу міг до нього звернутися*.

            /*прохання прокоментувати як краще (оптимально) звертатися до методу при використанні декількох екземплярів User
             - прибрати static та писати user.ShowUserInfo(user) , user2.ShowUserInfo(user2) і т.д.
            - чи User.ShowUserInfo(user)
             */



            Console.ReadKey();
        }
    }
}
