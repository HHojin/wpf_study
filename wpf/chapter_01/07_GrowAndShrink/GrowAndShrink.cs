﻿using System;
using System.Windows;
using System.Windows.Input;

namespace GrowAndShrink
{
    class GrowAndShrink : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new GrowAndShrink());
        }

        public GrowAndShrink()
        {
            Title = "Grow & Shrink";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Width = 192;
            Height = 192;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Key == Key.Up)
            {
                Left -= 0.05 * Width;
                Top -= 0.05 * Height;
                Width *= 1.1;
                Height *= 1.1;
            }
            else if(e.Key == Key.Down)
            {
                Left += 0.05 * (Width /= 1.1);
                Top += 0.05 * (Height /= 1.1);
            }
        }
    }
}
