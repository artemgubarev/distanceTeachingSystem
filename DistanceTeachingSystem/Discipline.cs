using System;
using System.Collections.Generic;

namespace DistanceTeachingSystem
{
    [Serializable]
    public class Discipline
    {
        private string title;
        public List<Guid> UsersId { get; set; }      

        public Discipline()
        {
            UsersId = new List<Guid>();
        }

        public Discipline(string title)
        {
            Title = title;
            UsersId = new List<Guid>();
        }

        public string Title
        {
            get => title;
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Title can not be empty!");

                title = value;
            }
        }      
    }
}
