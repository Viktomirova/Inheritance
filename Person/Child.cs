using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Age cannot be grater than 15");
                }

                base.Age = value;
            }
        }
    }
}
