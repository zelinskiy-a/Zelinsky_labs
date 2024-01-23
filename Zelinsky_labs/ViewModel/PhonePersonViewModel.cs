using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zelinsky_labs.Model;

namespace Zelinsky_labs.ViewModel
{
    class PhonePersonViewModel
    {
        public ObservableCollection<PhonePerson> ListPhonePerson { get; set; } = new ObservableCollection<PhonePerson>();

        public PhonePersonViewModel()
        {
            this.ListPhonePerson.Add(new PhonePerson {
                Id = 1,
                PersonID = 1,
                Phone = "(863)261-38-64"
            });

            this.ListPhonePerson.Add(new PhonePerson
            {
                Id = 2,
                PersonID = 2,
                Phone = "(499)111-11-11"
            });

            this.ListPhonePerson.Add(new PhonePerson
            {
                Id = 3,
                PersonID = 3,
                Phone = "(863)261-38-79"
            });
        }
    }
}
