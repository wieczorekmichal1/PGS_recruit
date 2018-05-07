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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Task.Pages;

namespace Task
{
    /// <summary>
    /// Logika interakcji dla klasy Imie.xaml
    /// </summary>
    public partial class Imie : Page
    {
        public Parameters Parameters;

        public Imie(Parameters parameters)
        {
            InitializeComponent();
            Parameters = parameters;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Parameters.Imie = ImieBlock.Text;
            Nazwisko NazwiskoPage = new Nazwisko(Parameters);
            this.NavigationService.Navigate(NazwiskoPage);
        }
    }
}
