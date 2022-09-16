using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{
    public class Person
    {
        private string _fullName = string.Empty;

        public string FullName
        {
            get { return _fullName; }

            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FullName value is required");
                }
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("FullName must contain 3 or more characters");
                }
                _fullName = value;
            }
        }

        public Person(string fullName)
        {
            FullName = fullName;
        }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
