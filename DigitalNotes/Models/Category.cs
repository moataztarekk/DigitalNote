using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotes.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public String? Name { get; set; }

        public virtual ICollection<Note> Notes { get; set; } = new HashSet<Note>();
    }
}
