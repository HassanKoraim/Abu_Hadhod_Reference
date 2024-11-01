using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyPropertyExample
{
    public class clsPerson
    {
        private int _Id = 10;
        private string _FirstName;
        private string _LastName;

        // property set
        public void setId(int Id)
        {
            _Id = Id;
        }

        // property Get
        public int Id()
        {
            return _Id;
        }
        // property set
        public void setFirstName(string name)
        {
            _FirstName = name;
        }

        // property Get
        public string GetFirstName()
        {
            return _FirstName;
        }
        // property set
        public void setLastName(string name)
        {
            _LastName = name;
        }

        // property Get
        public string LastName()
        {
            return _LastName;
        }

        public string GetFullName()
        {
            return _FirstName + " " + _LastName; 
        }
    }
}
