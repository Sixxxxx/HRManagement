using Microsoft.AspNetCore.Identity;
namespace HRManagementSystem.Models.Entities;

public class ApplicationUserClaim : IdentityUserClaim<string>
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; }
    public bool Active { get; set; }
}
