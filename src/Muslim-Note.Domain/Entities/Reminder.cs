using Muslim_Note.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muslim_Note.Domain.Entities
{
    public class Reminder : Auditable
    {
        public string Describtion { get; set; } = string.Empty;
    }
}
