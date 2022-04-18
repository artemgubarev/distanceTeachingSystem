using System;

namespace DistanceTeachingSystem
{
    [Serializable]
    public class Exercise
    {
        private double grade;
        private string title;

        public Exercise()
        {
        }

        public Exercise(double grade = 0.0)
        {
            Grade = grade;       
        }

        public Exercise(string title, double grade)
        {
            Title = title;
            Grade = grade;
        }

        public double Grade
        {
            get => grade;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Grade can not be negative!");
                grade = value;
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if(value.Length == 0)
                    throw new ArgumentException("Lenght can not be empty!");
                title = value;
            }
        }


    }
}