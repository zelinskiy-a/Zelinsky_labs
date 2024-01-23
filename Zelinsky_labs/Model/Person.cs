using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelinsky_labs.Model
{
    class Person
    {
        public int Id { get; set; }
        public int VerietyID { get; set; }
        public int StatusID { get; set; }
        public int Inn { get; set; }
        public string Type { get; set; }
        public string Shifer { get; set; }
        public DateTime Data { get; set; }
        public Person() { }
        public Person(int id, int verietyID, int statusID, int inn, string type, string shifer, DateTime data)
        {
            this.Id = id;
            this.VerietyID = verietyID;
            this.StatusID = statusID;
            this.Inn = inn;
            this.Type = type;
            this.Shifer = shifer;
            this.Data = data;
        }
    }

}