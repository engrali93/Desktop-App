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
using MahApps.Metro.Controls;
using ControlzEx.Theming;
using System.Diagnostics;
using DailyTool.WinForm;
using System.Media;

namespace DailyTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Draging move
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        // Exit BUtton
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            new SoundPlayer(".//sound//Click.wav").Play();
            Close();
        }

        private void WebProfile(object sender, RoutedEventArgs e)
        {
            NavigationWindow window = new NavigationWindow();

            Uri source = new Uri("http://www.c-sharpcorner.com/Default.aspx", UriKind.Absolute);
            
            window.Source = source; window.Show();

        }
        private void new_page(object sender, RoutedEventArgs e)
        {
            new SoundPlayer(".//sound//Click.wav").Play();
            MainWindow mw = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault(); //opening second WPF
            if (mw != null)
                mw.Content = new converter();
        }

        private void about_us_Click(object sender, RoutedEventArgs e)
        {
            new SoundPlayer(".//sound//Click.wav").Play();
            About about_us = new About();
            about_us.ShowDialog();
        }

        private void hyperlink_request_nav(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
