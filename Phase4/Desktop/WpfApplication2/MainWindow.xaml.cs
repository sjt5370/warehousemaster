﻿using System.Windows;
using System.Windows.Controls;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new ViewPage();
        }
    }
}