using Muslim_Note.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Note.Domain.Entities
{
    public class Note : Auditable
    {
        public long  UserId { get; set; }
        public User User { get; set; }
        public string NoteText { get; set; } = string.Empty;
    }
}
