using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media.Animation;

namespace wpfgfx
{
    public class CountdownButtonViewModel : DependencyObject, INotifyPropertyChanged
    {
        public static readonly DependencyProperty MessageProperty =
                    DependencyProperty.Register("Message", typeof(string),
                    typeof(CountdownButtonViewModel), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty SecondsProperty =
                      DependencyProperty.Register("Seconds", typeof(int),
                      typeof(CountdownButtonViewModel), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty FinalMessageProperty =
                      DependencyProperty.Register("FinalMessage", typeof(string),
                      typeof(CountdownButtonViewModel), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty CurrentSecondsProperty =
                      DependencyProperty.Register("CurrentSeconds", typeof(int),
                      typeof(CountdownButtonViewModel), new FrameworkPropertyMetadata(null));

        public event PropertyChangedEventHandler PropertyChanged;

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set
            {
                SetValue(MessageProperty, value);
                NotifyPropertyChanged(nameof(DisplayMessage));
            }
        }

        public string FinalMessage
        {
            get { return (string)GetValue(FinalMessageProperty); }
            set { SetValue(FinalMessageProperty, value); }
        }

        public int Seconds
        {
            get { return (int)GetValue(SecondsProperty); }
            set
            {
                SetValue(SecondsProperty, value);
                NotifyPropertyChanged(nameof(DisplayMessage));
            }
        }

        public Duration Duration
        {
            get
            {
                return new Duration(new TimeSpan(0,0,Seconds));
            }
        }

        public int CurrentSeconds {
            get { return (int)GetValue(CurrentSecondsProperty); }
            set
            {
                SetValue(CurrentSecondsProperty, value);
                NotifyPropertyChanged(nameof(DisplayMessage));
                NotifyPropertyChanged(nameof(IsEnabled));
            }
        }

        public string DisplayMessage
        {
            get
            {
                if (Seconds == 0)
                {
                    return FinalMessage;
                }
                return string.Format(Message, Seconds);
            }
        }

        public bool IsEnabled
        {
            get
            {
                return Seconds == 0;
            }
        }

        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
