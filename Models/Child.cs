using System.Collections.Generic;
using Hand_in_1.Models;

namespace Hand_in_1.Models {
public class Child : Person {
    
    public List<Interest> Interests { get; set; }
    public List<Pet> Pets { get; set; }
}
}