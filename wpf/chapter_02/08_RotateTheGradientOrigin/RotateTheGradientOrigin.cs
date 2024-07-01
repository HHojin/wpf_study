using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace RotateTheGradientOrigin
{
    class RotateTheGradientOrigin : Window
    {
        RadialGradientBrush brush;
        double angle;

        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new RotateTheGradientOrigin());
        }

        public RotateTheGradientOrigin()
        {
            Title = "Rotate the Gradient Origin";
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Width = 384;
            Height = 384;

            brush = new RadialGradientBrush(Colors.White, Colors.Blue);
            brush.Center = brush.GradientOrigin = new Point(0.5, 0.5);
            brush.RadiusX = brush.RadiusY = 0.10;
            brush.SpreadMethod = GradientSpreadMethod.Repeat;
            Background = brush;

            DispatcherTimer tmr = new();
            tmr.Interval = TimeSpan.FromMilliseconds(100);
            tmr.Tick += TimerOnTick;
            tmr.Start();
        }

        void TimerOnTick(Object senter, EventArgs e)
        {
            Point pt = new(0.5 + 0.05 * Math.Cos(angle),
                            0.5 + 0.05 * Math.Sin(angle));
            brush.GradientOrigin = pt;
            angle += Math.PI / 6;
        }
    }
}
