using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotes.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? ReminderDate { get; set; }

        //--------------------------------------------------------------


        // FK - Nav  (User)
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        //---------------------------------------------------------------

        // FK - Nav  (Category)
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
