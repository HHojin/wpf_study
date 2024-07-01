using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CircleTheRainbow
{
    class CircleTheRainbow : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new CircleTheRainbow());
        }

        public CircleTheRainbow()
        {
            Title = "Circle the Rainbow";

            RadialGradientBrush brush = new();
            Background = brush;

            brush.GradientStops.Add(new GradientStop(Colors.Red, 0));
            brush.GradientStops.Add(new GradientStop(Colors.Orange, .17));
            brush.GradientStops.Add(new GradientStop(Colors.Yellow, .33));
            brush.GradientStops.Add(new GradientStop(Colors.Green, .5));
            brush.GradientStops.Add(new GradientStop(Colors.Blue, .67));
            brush.GradientStops.Add(new GradientStop(Colors.Indigo, .84));
            brush.GradientStops.Add(new GradientStop(Colors.Violet, 1));
        }
    }
}
