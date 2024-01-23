using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelinsky_labs.Model
{
    class StatusPerson
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public StatusPerson() { }
        public StatusPerson(int id, string status)
        {
            this.Id = id;
            this.Status = status;
        }
    }
}