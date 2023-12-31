using Microsoft.AspNetCore.Identity;

namespace ShoppingApi.Data.Models.Auth;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}