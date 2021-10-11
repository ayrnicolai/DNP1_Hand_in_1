using System;
using System.Collections.Generic;
using System.Linq;
using Hand_in_1.Models;

namespace Hand_in_1.Data.Impl {
public class InMemoryUserService : IUserService {
    private List<User> users;

    public InMemoryUserService() {
        users = new[] {
            new User {
                ID = 123456,
                UserName = "Farmand",
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
                UserName = "Moderjord",
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
                UserName = "Sønnike",
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
        User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
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