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

namespace dbConnector
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Page
    {
        public InsertPage(String tableName)
        {
            InitializeComponent();
            labelTableName.Content = tableName;
        }

        private void ButtonQuery_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDone_Click(object sender, RoutedEventArgs e)
        {
            
        }        
    }
}
