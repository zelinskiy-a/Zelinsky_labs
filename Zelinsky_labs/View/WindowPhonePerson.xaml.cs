using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Zelinsky_labs.ViewModel;

namespace Zelinsky_labs.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPhonePerson.xaml
    /// </summary>
    public partial class WindowPhonePerson : Window
    {
        public WindowPhonePerson()
        {
            InitializeComponent();

            PhonePersonViewModel vmPhonePerson = new PhonePersonViewModel();
            lvPerson.ItemsSource = vmPhonePerson.ListPhonePerson;
        }
    }
}
