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
using System.Media;

using System.IO;
using Microsoft.Win32;
using System.Windows.Interop;
using DailyTool.WinForm;


namespace DailyTool
{
    /// <summary>
    /// Interaction logic for converter.xaml
    /// </summary>
    public partial class converter : Page
    {
        public converter()
        {
            InitializeComponent();
        }


        private void open_file1(object sender, RoutedEventArgs e)
        {
            new SoundPlayer(".//sound//Click.wav").Play();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Docx Files|*.docx";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                txtEditor.Text = fileName;
            }
               
        }

        private void CloseButton_Click2(object sender, RoutedEventArgs e)
        {
            new SoundPlayer(".//sound//Click.wav").Play();
            Application.Current.Shutdown(110);
        }



        private async void new_page2(object sender, RoutedEventArgs e)
        {
            string loc = txtEditor.Text;
            if (String.IsNullOrEmpty(txtEditor.Text))
            {
                new SoundPlayer(".//sound//error.wav").Play();
            }
            if (!(String.IsNullOrEmpty(txtEditor.Text)))
            {
                new SoundPlayer(".//sound//Click.wav").Play();

                load.Value = 10;
            var progress = new Progress<int>(x => load.Value = x);

            formula form = new formula(); // method of conversion
                                          // string outfile = form.convert_formula(loc); // getting output name
            string outfile = await Task.Run(() => form.convert_formula(loc, progress));
                //successbox successbox1 = new successbox();
                new SoundPlayer(".//sound//Windows Exclamation.wav").Play();

                successbox successbox1 = new successbox(outfile);
            successbox1.ShowDialog();
            txtEditor.Clear();
             load.Value = 0;
             }

        }
        private void ProgressBar(object sender, RoutedEventArgs e)
        {

        }
        private void Grid_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                
                
            }
        }
    }
}
