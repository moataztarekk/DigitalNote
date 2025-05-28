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

        public static void addUser(User user) 
        {
            users.Add(user);
        }
        public static List<User> getUsers() 
        {
           
            return users; 
        }
    }
}
