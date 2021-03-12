using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
        public static readonly DependencyProperty MessageProperty =
             DependencyProperty.Register("Message", typeof(string),
             typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty FinalMessageProperty =
             DependencyProperty.Register("FinalMessage", typeof(string),
             typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty SecondsProperty =
                     DependencyProperty.Register("Seconds", typeof(int),
                     typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty RemainingSecondsProperty =
                DependencyProperty.Register("RemainingSeconds", typeof(int),
                typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty CommandProperty =
                DependencyProperty.Register("Command", typeof(ICommand),
                typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public CountdownButton()
        {
            InitializeComponent();
        }

        public int Seconds
        {
            get
            {
                return (int)GetValue(SecondsProperty);
            }
            set
            {
                SetValue(SecondsProperty, value);
            }
        }

        public string Message
        {
            get
            {
                return (string)GetValue(MessageProperty);
            }
            set
            {
                SetValue(MessageProperty, value);
            }
        }

        public string FinalMessage
        {
            get
            {
                return (string)GetValue(MessageProperty);
            }
            set
            {
                SetValue(MessageProperty, value);
            }
        }

        public int RemainingSeconds
        {
            get
            {
                return (int)GetValue(RemainingSecondsProperty);
            }
            set
            {
                SetValue(RemainingSecondsProperty, value);
            }
        }

        public ICommand Command
        {
            get
            {
                return (ICommand)GetValue(CommandProperty);
            }
            set
            {
                SetValue(CommandProperty, value);
            }
        }
    }
}
