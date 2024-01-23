using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelinsky_labs.Model
{
    class EmailPerson
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public string Email { get; set; }
        public EmailPerson() { }
        public EmailPerson(int id, int personID, string email)
        {
            this.Id = id;
            this.PersonID = personID;
            this.Email = email;
        }
    }
}
