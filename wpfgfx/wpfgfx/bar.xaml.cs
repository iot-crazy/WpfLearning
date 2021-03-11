using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfgfx
{
    /// <summary>
    /// Interaction logic for bar.xaml
    /// </summary>
    public partial class bar : UserControl
    {
        public bar()
        {
            InitializeComponent();


            var rect = new Rectangle();
            rect.Stroke = Brushes.Black;
            rect.Width = Width;
            rect.Height = Height;

            Cnv.Children.Add(rect);
            Canvas.SetTop(rect, 0);
            Canvas.SetLeft(rect, 0);

            var rectInner = new Rectangle();
            rectInner.Stroke = Brushes.Black;
            rectInner.Width = ActualWidth ;
            rectInner.Height = ActualHeight ;

            Cnv.Children.Add(rectInner);
            Canvas.SetTop(rectInner, 2);
            Canvas.SetLeft(rectInner, 2);


        }
    }
}
