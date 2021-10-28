using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hand_in_1.Models;

namespace Hand_in_1.Data.Impl {
public class InMemoryUserService : IUserService {
    private List<User> users;

    public InMemoryUserService() {
        users = new[] {
            new User {
                ID = 123456,
                Username = "Farmand",
                FirstName = "Kenned",
                LastName = "Ødegaard",
                HairColor = "Black",
                EyeColor = "Brown",
                Age = 53,
                Weight = 84,
                Height = 180,
                Sex = "Male",
                SecurityLevel = 5,
                Password = "1234",
            },
            new User {
                ID = 123456,
                Username = "Moderjord",
                FirstName = "Birgitte",
                LastName = "Tierney",
                HairColor = "Brown",
                EyeColor = "Brown",
                Age = 49,
                Weight = 62,
                Height = 170,
                Sex = "Female",
                SecurityLevel = 4,
                Password = "12345",
            },
            new User {
                ID = 123456,
                Username = "Sønnike",
                FirstName = "Pierre",
                LastName = "Aubameyang",
                HairColor = "Black",
                EyeColor = "Green",
                Age = 16,
                Weight = 74,
                Height = 176,
                Sex = "Male",
                SecurityLevel = 2,
                Password = "123456",
            }
        }.ToList();
    }


    public User ValidateUser(string userName, string password) {
        throw new NotImplementedException();
    }
    
    public async Task<User> ValidateLogin(string username, string password)
    {
        User first = users.FirstOrDefault(user => user.Username.Equals(username));
        if (first == null) {
            throw new Exception("User not found in family");
        }

        if (!first.Password.Equals(password)) {
            throw new Exception("Incorrect password");
        }

        return first;
    }
}
}