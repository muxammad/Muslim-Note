namespace Muslim_Note.Domain.Entities;

public class MissedNamozTime
{
    public long UserId { get; set; }
    public User User { get; set; }
    public DateOnly MissedDay { get; set; }
    public string Describtion { get; set; } = string.Empty;

}
