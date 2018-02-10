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
    public partial class FindElementsInHostCoordinates_Demo : UserControl
    {
        private int _highestZIndex;

        public FindElementsInHostCoordinates_Demo()
        {
            this.InitializeComponent();
            InitAllZIndex();
            _highestZIndex = 2;

            this.PointerPressed += FindElementsInHostCoordinates_Demo_PointerPressed;
        }

        void FindElementsInHostCoordinates_Demo_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Point currentPoint = e.GetCurrentPoint(null).Position; //get aboslute coordinate of the point

            var uiElement = VisualTreeHelper.FindElementsInHostCoordinates(currentPoint, CanvasParent).ToList<UIElement>()[0]; //we get the element that has been clicked on

            //We clicked in a border
            if (uiElement is Border)
            {
                Canvas.SetZIndex(uiElement, _highestZIndex + 1); //set that border to the front
                ++_highestZIndex;
            }
        }
        
        void InitAllZIndex()
        {
            // 0 -> 2 is from the background to the front
            Canvas.SetZIndex(BlueRectangle, 0);
            Canvas.SetZIndex(GreenRectangle, 1);
            Canvas.SetZIndex(YellowRectangle, 2);
        }

    }
}
