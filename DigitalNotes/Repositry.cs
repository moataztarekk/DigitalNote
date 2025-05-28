using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotes
{
    public  class Repositry
    {

        static List<User> users = new List<User>()
        {
             new User(){ Name = "Heba" , Password = "1234"},
             new User(){ Name = "Sam" , Password = "12345"},
             new User(){ Name = "Nada" , Password = "123456"},
             new User(){ Name = "Mohamed" , Password = "1234"},
        };

<<<<<<< HEAD
        public static void addUser(User user) 
        {
            users.Add(user);
        }
=======
>>>>>>> 63a0501cdf81bc8a3ea53c84a5d9fad084c88654
        public static List<User> getUsers() 
        {
           
            return users; 
        }
    }
}
