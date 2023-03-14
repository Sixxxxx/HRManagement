using Microsoft.AspNetCore.Identity;

namespace HRManagementSystem.Models.Entities;

public class ApplicationUserRole : IdentityUserRole<string>
{
    public virtual ApplicationUser User { get; set; }
    public virtual ApplicationRole Role { get; set; }
}