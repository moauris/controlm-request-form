﻿using controlm_request_form.ViewModels;
using controlm_request_form.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace controlm_request_form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
#if DEBUG
            Debug.Print("Starting App with Debug mode");
#endif
            InitializeComponent();

            ViewModel = Resources["viewmodel"] as MainWindowViewModel;
            if (ViewModel == null)
            {
                throw new NullReferenceException("ViewModel can't be null");
            }
        }

        private MainWindowViewModel ViewModel = null;

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void OnPICTextboxDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            var window = new PicPicker();
            window.Show();
        }

        private void CanExecute_AddCommand(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void Execute_AddCommand(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
