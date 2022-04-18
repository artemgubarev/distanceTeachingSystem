using System;
using System.Collections.Generic;

namespace DistanceTeachingSystem
{
    [Serializable]
    public class Student : User
    {
        private string password;

        public Student()
        {           
            Exercises = new List<Exercise>();
            GradeList = new Dictionary<string, double>();
        }

        public override string Password
        {
            get { return password; }
            set
            { 
                if (value.Length == 0)
                    throw new ArgumentException("Пароль не может быть пустым!");

                password = value;
            }
        }

        public List<Exercise> Exercises { get; set; }

        public Dictionary<string, double> GradeList { get; set; }
    }
}
