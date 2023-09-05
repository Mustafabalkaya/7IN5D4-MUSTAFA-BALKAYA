using MinimalJwt.Models;

namespace MinimalJwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "Mustafa", EmailAddress = "mustafa@gmail.com", Password = "Balkaya46.", GivenName = "Mustafa", Surname = "Balkaya", Role = "Administrator" },
            new() { Username = "Simge", EmailAddress = "simge@gmail.com", Password = "SimgeTiryaki.", GivenName = "Simge", Surname = "Tiryaki", Role = "Standard" },
        };
    }
}
