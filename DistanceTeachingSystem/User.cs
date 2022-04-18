using System;

namespace DistanceTeachingSystem
{

    [Serializable]
    public abstract class User
    {
        private string name;      
        public Guid Id { get; }

        public abstract string Password { get; set; }

        public User()
        {
           this.Id = Guid.NewGuid();
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length == 0)
                    throw new ArgumentException("Name lenght can not be empty!");

                name = value;
            }
        }

        
    }
}
