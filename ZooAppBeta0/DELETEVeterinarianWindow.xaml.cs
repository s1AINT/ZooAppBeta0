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

namespace ZooAppBeta0
{
    /// <summary>
    /// Interaction logic for DELETEVeterinarianWindow.xaml
    /// </summary>
    public partial class DELETEVeterinarianWindow : Window
    {
        public DELETEVeterinarianWindow()
        {
            InitializeComponent();
        }
        private void ButtonBackToVeterOperWindow(object sender, RoutedEventArgs e)
        {
            VeterinariansOperationsWindow veterOperWind = new VeterinariansOperationsWindow();
            veterOperWind.Show();
            this.Hide();
        }
        private void ButtonToDELETEVeterinarianClick(object sender, RoutedEventArgs e)
        {
            /*
            AnimalsOperations animalsOperations = new AnimalsOperations();
            animalsOperations.Show();
            this.Hide();*/
        }
    }
}
