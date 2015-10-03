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

namespace Zadatak04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ucitajFontove();
        }

        private void ucitajFontove()
        {
            List<string> fontfamilies = new List<string>();
            foreach (FontFamily family in FontFamily.Families)
            {
                fontfamilies.Add(family.Name);
            }
            //return fontfamilies;       

        }
    }
}
