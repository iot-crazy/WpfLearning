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
    /// Interaction logic for MessageUserControl.xaml
    /// </summary>
    public partial class MessageUserControl : UserControl
    {

        public static readonly DependencyProperty MessageProperty =
                DependencyProperty.Register("Message", typeof(string),
                typeof(MessageUserControl), new FrameworkPropertyMetadata(null));

        public MessageUserControl()
        {
            InitializeComponent();
           
            DataContext = this;
        }


        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

    }
}
