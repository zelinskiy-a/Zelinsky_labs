using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zelinsky_labs.Model;

namespace Zelinsky_labs.ViewModel
{
    class VerietyPersonViewModel
    {
        public ObservableCollection<VerietyPerson> ListVerietyPerson { get; set; } = new ObservableCollection<VerietyPerson>();

        public VerietyPersonViewModel()
        {
            this.ListVerietyPerson.Add(new VerietyPerson
            {
                Id = 1,
                Veriety = "Инвестор",
            });

            this.ListVerietyPerson.Add(new VerietyPerson
            {
                Id = 2,
                Veriety = "Доверительное управление",
            });
        }
    }
}
