using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotes
{
    public class Repository
    {

        static List<User> users = new List<User>()
        {
             new User(){ Name = "Heba" , Password = "1234"},
             new User(){ Name = "Sam" , Password = "12345"},
             new User(){ Name = "Nada" , Password = "123456"},
             new User(){ Name = "Mohamed" , Password = "1234"},
        };

        public static BindingList<Note> notes = new BindingList<Note>()
        {
            new Note(){ NoteId = 1, Title = "n1", Category = "c1", CreationDate = DateTime.Now, UserId = 4 },
            new Note(){ NoteId = 2, Title = "n2", Category = "c1", CreationDate = DateTime.Now, UserId = 4 },
            new Note(){ NoteId = 3, Title = "n3", Category = "c2", CreationDate = DateTime.Now, UserId = 3 },
            new Note(){ NoteId = 4, Title = "n4", Category = "c2", CreationDate = DateTime.Now, UserId = 3 },
            new Note(){ NoteId = 5, Title = "n5", Category = "c3", CreationDate = DateTime.Now, UserId = 2 },
            new Note(){ NoteId = 6, Title = "n6", Category = "c3", CreationDate = DateTime.Now, UserId = 2 },
            new Note(){ NoteId = 7, Title = "n7", Category = "c4", CreationDate = DateTime.Now, UserId = 1 },
            new Note(){ NoteId = 8, Title = "n8", Category = "c4", CreationDate = DateTime.Now, UserId = 1 },
        };

        public static List<string> Categories = new List<string>()
        {
            "Work", "Study", "Personal Life", "Tasks", "Ideas"
        };

        public static void addCategory(string category)
        {
            Categories.Add(category);
        }
        public static void addUser(User user) 
        {
            users.Add(user);
        }

        public static List<User> getUsers() 
        {
            return users; 
        }

        public static void addNote(Note note)
        {
            notes.Add(note);
        }

        public static void updateNote(int noteId, Note note)
        {
        }

        public static BindingList<Note> getNotes()
        {
            return notes;
        }
    }
}
