using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AsyncAwait
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

        private void executeSync_Click(object sender, RoutedEventArgs e)
        {
            //Everything in between brackets of this method is gets timed.
            var watch = Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            resultsWindow.Text = $"Total execution time: {elapsedMs}";
        }

        /// <summary>
        /// Clears out resultsWindow 
        /// </summary>
        /// <returns>A list of sites</returns>
        private List<string> PrepData()
        {
            List<string> sites = new List<string>();
            resultsWindow.Text = "";

            sites.Add("https://www.yahoo.com");
            sites.Add("https://www.google.com");
            sites.Add("https://www.microsoft.com");
            sites.Add("https://www.cnn.com");
            sites.Add("https://www.codeproject.com");
            sites.Add("https://www.stackoverflow.com");

            return sites;
        }

        private void RunDownloadSync()
        {
            throw new NotImplementedException();
        }

        private void executeAsync_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
