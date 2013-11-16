using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PomodoroTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        DateTime StartTime;
        TimeSpan currentTime = new TimeSpan(0, 25, 0);

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //var timeLeft = TimeLeft(StartTime);
            TimerLable.Content  = String.Format("{0:00}:{1:00}", TimeLeft(StartTime).Minutes, TimeLeft(StartTime).Seconds);
        }

        private void StartTimerButton_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Start();
            StartTime = DateTime.Now;
        }


        //Set up the time calculatorion of the 20 minutes
        public TimeSpan TimeLeft(DateTime StartTime)
        {

            return currentTime - (DateTime.Now - StartTime);
        }
        

    }
}
