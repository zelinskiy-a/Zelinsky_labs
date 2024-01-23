using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zelinsky_labs.Model;

namespace Zelinsky_labs.ViewModel
{
    class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } = new ObservableCollection<Person>();
        
        public PersonViewModel()
        {
            this.ListPerson.Add(new Person
            {
                Id = 1,
                VerietyID = 1,
                StatusID = 1,
                Inn = 123456789,
                Type = "Физическое лицо",
                Shifer = "AM-SdHsabNAnQK32for-FQOxdqVD335tJA",
                Data = new DateTime(2024, 01, 20)
            });
            
            this.ListPerson.Add(new Person
            {
                Id = 2,
                VerietyID = 2,
                StatusID = 2,
                Inn = 24681357,
                Type = "Юридическое лицо",
                Shifer = "SM-SdFKJdnskNAnQK32for-jhdnVD335tDA",
                Data = new DateTime(2022, 02, 21)
            });
            
            this.ListPerson.Add(new Person
            {
                Id = 3,
                VerietyID = 1,
                StatusID = 1,
                Inn = 87654321,
                Type = "Физическое лицо",
                Shifer = "AD-hjffkdnf45oR-FfjdbfdfnGJ555",
                Data = new DateTime(2024, 01, 23)
            });
        }
    }
}
