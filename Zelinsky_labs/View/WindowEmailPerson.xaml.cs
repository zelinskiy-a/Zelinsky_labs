﻿using System;
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
    /// Логика взаимодействия для WindowEmailPerson.xaml
    /// </summary>
    public partial class WindowEmailPerson : Window
    {
        public WindowEmailPerson()
        {
            InitializeComponent();

            EmailPersonViewModel vmEmailPerson = new EmailPersonViewModel();
            lvPerson.ItemsSource = vmEmailPerson.ListEmailPerson;
        }
    }
}
