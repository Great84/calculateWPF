﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace calculate
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Text += 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Answer.Text += 2;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Answer.Text += 3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Answer.Text += 4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Answer.Text += 5;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Answer.Text += 6;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Answer.Text += 7;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Answer.Text += 8;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Answer.Text += 9;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Answer.Text += ".";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Answer.Text += 0;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

            DataTable dt = new DataTable();
            var result = dt.Compute(Answer.Text, "");
            Answer2.Text=result.ToString();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Answer.Text += "+";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Answer.Text += "-";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Answer.Text += "*";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Answer.Text += "/";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Answer.Text = Answer.Text.Substring(0,Answer.Text.Length-1) ;
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Answer.Text = "";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            Answer.Text = "";
        }
    }
}
