using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_Encapsulation.app
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public void SetFirstName(string firstName)
        {
            if (firstName.Length >= 3)
            {
                this.firstName = firstName;
            }
        }

        public void SetMiddleName(string middleName)
        {
            this.middleName = middleName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverseName = String.Empty;
            for (int i = cArray.Length-1; i >-1; i--)
            {
                reverseName += cArray[i];
            }
            return reverseName;
        }

    }
}
