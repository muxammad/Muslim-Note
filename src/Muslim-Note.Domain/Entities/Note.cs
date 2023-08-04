using Muslim_Note.Domain.Commons;

namespace Muslim_Note.Domain.Entities;

public class Note : Auditable
{
    public long  UserId { get; set; }
    public User User { get; set; }
    public string NoteText { get; set; } = string.Empty;
}
