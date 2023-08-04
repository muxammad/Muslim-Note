using Muslim_Note.Domain.Commons;

namespace Muslim_Note.Domain.Entities;

public class Debt : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; } = default!;
    public decimal Amount { get; set; }
    public string Lender { get; set; } = string.Empty;
    public DateOnly FundingDate { get; set; }
    public DateOnly DueData { get; set; }
}
