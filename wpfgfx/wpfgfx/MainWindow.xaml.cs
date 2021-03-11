using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private double _width = 398;

        public double width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                OnPropertyChanged("width");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public int height = 50;

        public Timer aTimer;


        public MainWindow()
        {
            InitializeComponent();
            countdownButtonViewModel = new CountdownButtonViewModel()
            {
                Message = "Ready in ({0})",
                FinalMessage = "Ready",
                Seconds = 5,
            };
            DataContext = this;
          //  DrawBar();
          // SetTimer();
        }


        public CountdownButtonViewModel countdownButtonViewModel { get; set; }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(50);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        //public void DrawBar()
        //{
            

        //    var rect = new Rectangle();
        //    rect.Stroke = Brushes.Black;
        //    rect.Width = width;
        //    rect.Height = height;

        //    Cnv.Children.Add(rect);
        //    Canvas.SetTop(rect, 0);
        //    Canvas.SetLeft(rect, 0);

        //    var rectInner = new Rectangle();
        //    rectInner.Stroke = Brushes.Red;
        //    rectInner.Fill = Brushes.Red;
        //    rectInner.Width = width - 2;
        //    rectInner.Height = height - 2;

        //    Cnv.Children.Add(rectInner);
        //    Canvas.SetTop(rectInner, 1);
        //    Canvas.SetLeft(rectInner, 1);
        //}

        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            width -= 1;
        }

    }
}
