using System.Threading.Tasks;
using Hand_in_1.Models;

namespace Hand_in_1.Data {
public interface IUserService {
    User ValidateUser(string userName, string password);

    Task<User> ValidateLogin(string username, string password);
}
}