using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Entities
{
    public class Cameraman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumOfExperience { get; set; }


        public Cameraman(int id, string name, int numOfExperience)
        {
            Id = id;
            Name = name;
            NumOfExperience = numOfExperience;

        }
    }
}
