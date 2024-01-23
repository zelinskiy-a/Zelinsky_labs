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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zelinsky_labs.View;

namespace Zelinsky_labs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Person_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPerson wPerson = new WindowPerson();
            wPerson.Show();
        }

        private void EmailPerson_OnClick(object sender, RoutedEventArgs e)
        {
            WindowEmailPerson wEmailPerson = new WindowEmailPerson();
            wEmailPerson.Show();
        }

        private void PhonePerson_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPhonePerson wPhonePerson = new WindowPhonePerson();
            wPhonePerson.Show();
        }

        private void StatusPerson_OnClick(object sender, RoutedEventArgs e)
        {
            WindowStatusPerson wStatusPerson = new WindowStatusPerson();
            wStatusPerson.Show();
        }

        private void VerietyPerson_OnClick(object sender, RoutedEventArgs e)
        {
            WindowVerietyPerson wVerietyPerson = new WindowVerietyPerson();
            wVerietyPerson.Show();
        }

    }
}
