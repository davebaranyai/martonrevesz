﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace RPGGame
{
    public class FoxDraw
    {
        public const int TileSize = 50;
        public Canvas Canvas { get; set; }
        public List<Image> Items { get; set; }

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
            Items = new List<Image>();
        }

        public void AddImage(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TileSize,
                Height = TileSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Items.Add(image);
            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public double GetLeft(UIElement uIElement)
        {
            return Canvas.GetLeft(uIElement);
        }

        public double GetTop(UIElement uIElement)
        {
            return Canvas.GetTop(uIElement);
        }

        public void ClearCanvas()
        {
            Canvas.Children.Clear();
        }
    }
}
