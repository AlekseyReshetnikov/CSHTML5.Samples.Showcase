﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CSHTML5.Samples.Showcase
{
    public partial class ContextMenu_Demo : UserControl
    {
        public ContextMenu_Demo()
        {
            this.InitializeComponent();
        }

        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Item 1");
        }

        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Item 2");
        }

        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Item 3");
        }
    }
}
