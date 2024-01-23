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
    /// Логика взаимодействия для WindowVerietyPerson.xaml
    /// </summary>
    public partial class WindowVerietyPerson : Window
    {
        public WindowVerietyPerson()
        {
            InitializeComponent();

            VerietyPersonViewModel vmVerietyPerson = new VerietyPersonViewModel();
            lvPerson.ItemsSource = vmVerietyPerson.ListVerietyPerson;
        }
    }
}
