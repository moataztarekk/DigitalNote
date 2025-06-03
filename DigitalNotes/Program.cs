using DigitalNotes.Data;
using DigitalNotes.Models;
using System.ComponentModel;
using WFDemo;

namespace DigitalNotes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DigitalNoteDbContext db = new DigitalNoteDbContext();

            #region Data

            //User u1 = new User() { UserName = "Heba", Password = "1234" };
            //User u2 = new User() { UserName = "Sam", Password = "12345" };
            //User u3 = new User() { UserName = "Nada", Password = "123456" };
            //User u4 = new User() { UserName = "Mohamed", Password = "1234" };

            //List<User> _users = new List<User>()
            //{
            //    new User() { UserName = "Heba", Password = "1234" },
            //    new User() { UserName = "Sam", Password = "12345" },
            //    new User() { UserName = "Nada", Password = "123456" },
            //    new User() { UserName = "Mohamed", Password = "1234" },
            //};

            //List<Category> _categories = new List<Category>()
            //{
            //    new Category() { Name = "Study" },
            //    new Category() { Name = "Play" },
            //    new Category() { Name = "Cook" }
            //};
            //Category c1 = new Category() { Name = "Study" };
            //Category c2 = new Category() { Name = "Play" };
            //Category c3 = new Category() { Name = "Cook" };

            //List<Note> _notes = new List<Note>()
            //{
            //    new Note(){ Title = "n1", CategoryId =1 , CreationDate = DateTime.Now, UserId = 4 },
            //    new Note(){ Title = "n2", CategoryId =2, CreationDate = DateTime.Now, UserId = 4 },
            //    new Note(){ Title = "n3", CategoryId =3, CreationDate = DateTime.Now, UserId = 3 },
            //    new Note(){ Title = "n4", CategoryId =1 , CreationDate = DateTime.Now, UserId = 3 },
            //    new Note(){ Title = "n5", CategoryId =1 , CreationDate = DateTime.Now, UserId = 2 },
            //    new Note(){ Title = "n6", CategoryId =1 , CreationDate = DateTime.Now, UserId = 2 },
            //    new Note(){ Title = "n7", CategoryId =2 , CreationDate = DateTime.Now, UserId = 1 },
            //    new Note(){ Title = "n8", CategoryId =3 , CreationDate = DateTime.Now, UserId = 1 },
            //};
            //Note n1 = new Note() { Title = "n1", CategoryId = 1, CreationDate = DateTime.Now, UserId = 4 };
            //Note n2 = new Note() { Title = "n2", CategoryId = 2, CreationDate = DateTime.Now, UserId = 4 };
            //Note n3 =new Note() { Title = "n3", CategoryId = 3, CreationDate = DateTime.Now, UserId = 3 };
            //Note n4 =new Note() { Title = "n4", CategoryId = 1, CreationDate = DateTime.Now, UserId = 3 };
            //Note n5 =new Note() { Title = "n5", CategoryId = 1, CreationDate = DateTime.Now, UserId = 2 };
            //Note n6 =new Note() { Title = "n6", CategoryId = 1, CreationDate = DateTime.Now, UserId = 2 };
            //Note n7 =new Note() { Title = "n7", CategoryId = 2, CreationDate = DateTime.Now, UserId = 1 };
            //Note n8 = new Note() { Title = "n8", CategoryId = 3, CreationDate = DateTime.Now, UserId = 1 };

            //db.AddRange(u1,u2,u3,u4);
            //db.AddRange(c1,c2,c3);
            //db.AddRange(n1,n2,n3,n4,n5,n6,n7,n8);
            //db.SaveChanges();
            #endregion

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}