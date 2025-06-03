using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotes.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }

        // Relation : 1 - M
        public virtual ICollection<Note> Notes { get; set; } = new HashSet<Note>();

    }
}
