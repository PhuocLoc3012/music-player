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

namespace MusicPlayerUI
{
    /// <summary>
    /// Interaction logic for SongInfo.xaml
    /// </summary>
    public partial class SongInfo : UserControl
    {
        public SongInfo()
        {
            InitializeComponent();
        }
        private event EventHandler backToMain;
        public event EventHandler BackToMain
        {
            add { backToMain += value; }
            remove { backToMain -= value; }
        }
        private void ClickButton_Click(object sender, RoutedEventArgs e)
        {
            if (backToMain != null)
            {
                backToMain(this, new EventArgs());
            } 
                
        }
    }
}
