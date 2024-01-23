using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zelinsky_labs.Model;

namespace Zelinsky_labs.ViewModel
{
    class StatusPersonViewModel
    {
        public ObservableCollection<StatusPerson> ListStatusPerson { get; set; } = new ObservableCollection<StatusPerson>();

        public StatusPersonViewModel()
        {
            this.ListStatusPerson.Add(new StatusPerson
            {
                Id = 1,
                Status = "Активный",
            });

            this.ListStatusPerson.Add(new StatusPerson
            {
                Id = 2,
                Status = "Неактивный",
            });
        }
    }
}
