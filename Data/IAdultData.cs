using System.Collections.Generic;
using System.Threading.Tasks;
using Hand_in_1.Models;

namespace Hand_in_1.Models
{
    public interface IAdultData
    {
        Task<IList<Person>> getAdult();
        Task AddAdultAsync(Person adult);
        Task RemoveAdultAsync(int id);
    }
}