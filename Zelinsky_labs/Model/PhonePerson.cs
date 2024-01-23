using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelinsky_labs.Model
{
    class PhonePerson
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public string Phone { get; set; }
        public PhonePerson() { }
        public PhonePerson(int id, int personID, string phone)
        {
            this.Id = id;
            this.PersonID = personID;
            this.Phone = phone;
        }
    }
}
