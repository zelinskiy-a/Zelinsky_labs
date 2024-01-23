using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zelinsky_labs.Model;

namespace Zelinsky_labs.ViewModel
{
    class EmailPersonViewModel
    {
        public ObservableCollection<EmailPerson> ListEmailPerson { get; set; } = new ObservableCollection<EmailPerson>();

        public EmailPersonViewModel()
        {
            this.ListEmailPerson.Add(new EmailPerson
            {
                Id = 1,
                PersonID = 1,
                Email = "celt@inbox.ru"
            });

            this.ListEmailPerson.Add(new EmailPerson
            {
                Id = 2,
                PersonID = 2,
                Email = "OOO_price@yandex.ru"
            });

            this.ListEmailPerson.Add(new EmailPerson
            {
                Id = 3,
                PersonID = 3,
                Email = "dekanat.zaoch@yandex.ru"
            });
        }
    }
}
