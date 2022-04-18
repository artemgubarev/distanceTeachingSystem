using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceTeachingSystem
{
    [Serializable]
    public class Teacher : User
    {
        private string password;

        public Teacher()
        {

        }

        public override string Password
        {          
            get { return password; }
            set
            {
                if (value.Length < 5)
                    throw new ArgumentException("Длинна пароля не может быть меньше 5");

                password = value;
            }
        }

    }
}
