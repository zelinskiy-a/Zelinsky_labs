using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelinsky_labs.Model
{
    class VerietyPerson
    {
        public int Id { get; set; }
        public string Veriety { get; set; }
        public VerietyPerson() { }
        public VerietyPerson(int id, string veriety)
        {
            this.Id = id;
            this.Veriety = veriety;
        }
    }
}
