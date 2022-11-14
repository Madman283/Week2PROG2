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

namespace NavDemoWeek10._1
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        MainWindow window = (MainWindow)Application.Current.MainWindow;
        DispatcherTimer timer;
        TimeSpan timeSpan;
        public Start()
        {
            InitializeComponent();
            Counter();
            Submit.Visibility = Visibility.Collapsed;

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.game.Player.Name = Input.Text;
            //Output.Text = MainWindow.game.Player.Name;
            NavigationService.Navigate(new Uri("GamePage.xaml", UriKind.Relative));
            Submit.Visibility = Visibility.Collapsed;

        }

        private void Counter()
        {
            
            timeSpan = TimeSpan.FromSeconds(5);

            timer = new DispatcherTimer(
                new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal,
                delegate
                {
                    TimerTextBlock.Text = timeSpan.ToString("c");
                    if (timeSpan == TimeSpan.Zero)
                    {
                        timer.Stop();
                        //MainWindow.game.Player.Score++;
                        //PlayerScore.Text = $"Your Score is {MainWindow.game.Player.Score}";
                        TimePasses();
                        
                        //Show the "next day" button
                        //btnNextDay.Visibility = Visibility.Visible;
                    }
                    timeSpan = timeSpan.Add(TimeSpan.FromSeconds(-1));
                },
                Application.Current.Dispatcher);

            timer.Start();
        }

        private void TimePasses()
        {
            Submit.Visibility = Visibility.Visible;
            MainWindow.game.Player.Score++;
            PlayerScore.Text = $"Your Score is {MainWindow.game.Player.Score}";
            Counter();
        }


    }
}
