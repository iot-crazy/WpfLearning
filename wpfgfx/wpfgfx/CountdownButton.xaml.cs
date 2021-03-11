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
                     DependencyProperty.Register("Seconds", typeof(TimeSpan),
                     typeof(CountdownButton), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty RemainingSecondsProperty =
                DependencyProperty.Register("RemainingSeconds", typeof(int),
                typeof(CountdownButton), new FrameworkPropertyMetadata(null));


        public CountdownButton()
        {
            InitializeComponent();
        }


        public TimeSpan Seconds
        {
            get { return (TimeSpan)GetValue(SecondsProperty); }
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

        //public string DisplayMessage
        //{
        //    get
        //    {
        //        if (Seconds. == 0)
        //        {
        //            return FinalMessage;
        //        }
        //        return string.Format(Message, RemainingSeconds);
        //    }
        //}



    }
}
