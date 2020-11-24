using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class PersonExeption : Exception
    {
        public string PersonName { get;}
        public int PersonListId { get; set; }

        public PersonExeption(string msg, string personName, int personId) : base($"{msg} ")
        {
            this.PersonName = personName;
            this.PersonListId = personId;
        }

    }
}
