using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Note title must contain a minimum of 2 characters.")]
        [MaxLength(100, ErrorMessage ="Note title must contain a maximum of 100 characters.")]
        public string Title { get; set; }
        [MaxLength(8000, ErrorMessage ="Note content must containt a maximum of 8000 characters.")]
        public string Content { get; set; }

    }
}
