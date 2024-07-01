using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ClickTheGradientCenter
{
    class ClickTheGradientCenter : Window
    {
        RadialGradientBrush brush;

        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new ClickTheGradientCenter());
        }

        public ClickTheGradientCenter()
        {
            Title = "Click the Gradient Center";
            brush = new RadialGradientBrush(Colors.Indigo, Colors.Orange);
            brush.RadiusX = brush.RadiusY = 0.10;
            brush.SpreadMethod = GradientSpreadMethod.Repeat;
            Background = brush;
            Width = 500;
            Height = 500;
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            double width = ActualWidth
                - 2 * SystemParameters.ResizeFrameVerticalBorderWidth;
            double height = ActualHeight
                - 2 * SystemParameters.ResizeFrameHorizontalBorderHeight - SystemParameters.CaptionHeight;
            Point ptMouse = e.GetPosition(this);
            ptMouse.X /= width;
            ptMouse.Y /= height;
            if (e.ChangedButton == MouseButton.Left)
            {
                brush.Center = ptMouse;
                brush.GradientOrigin = ptMouse;
            }
            else if (e.ChangedButton == MouseButton.Right)
                brush.GradientOrigin = ptMouse;
        }
    }
}
