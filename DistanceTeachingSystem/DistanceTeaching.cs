using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceTeachingSystem
{
    [Serializable]
    public class DistanceTeaching
    {
        public DistanceTeaching()
        {
            Disciplines = new List<Discipline>();
            Users = new List<User>();
        }

        public List<Discipline> Disciplines { get; set; }
        public List<User> Users { get; set; }
    }
}
