using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Person
{
    class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.Name + "\n");

            if (this.Age == null)
            {
                sb.Append("Age: N/A");
            }
            else
            {
                sb.Append("Age: " + this.Age + "");
            }

            return sb.ToString();
        }
    }
}
