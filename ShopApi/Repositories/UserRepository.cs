using ShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User{Id = 1, Username = "Darth Vader", Password = "123", Role = "lord"});
            users.Add(new User{ Id = 1, Username = "Darth Moul", Password = "123", Role = "soldier"});
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
