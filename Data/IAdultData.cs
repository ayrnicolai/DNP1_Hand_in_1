using System.Collections.Generic;
using Hand_in_1.Models;

namespace Hand_in_1.Models
{
    public interface IAdultData
    {
        IList<Person> getAdult();
        void AddAdult(Person adults);
        void RemoveAdult(int id);
    }
}