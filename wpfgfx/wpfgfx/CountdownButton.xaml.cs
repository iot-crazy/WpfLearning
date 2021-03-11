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
    /// Interaction logic for CountdownButton.xaml
    /// </summary>
    public partial class CountdownButton : UserControl
    {
        public static readonly DependencyProperty ViewModelProperty =
                DependencyProperty.Register("ViewModel", typeof(string),
                typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public CountdownButton()
        {
            InitializeComponent();
        }

        public CountdownButtonViewModel ViewModel
        {
            get { return (CountdownButtonViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

    }
}
