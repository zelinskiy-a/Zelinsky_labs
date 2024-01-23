using System.Windows;
using Zelinsky_labs.ViewModel;

namespace Zelinsky_labs.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        public WindowPerson()
        {
            InitializeComponent();

            PersonViewModel vmEmailPerson = new PersonViewModel();
            lvPerson.ItemsSource = vmEmailPerson.ListPerson;
        }
    }
}
