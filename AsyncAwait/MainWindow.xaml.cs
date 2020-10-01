using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void executeSync_Click(object sender, RoutedEventArgs e)
        {
            //Everything in between brackets of this method is gets timed.
            var watch = Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            resultsWindow.Text += $"Total execution time: {elapsedMs}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void executeAsync_Click(object sender, RoutedEventArgs e)
        {
            var watch = Stopwatch.StartNew();
            await RunDownloadParallelAsync();//If this call is not awaited, execution of the current method continues before the call is completed.(Timer is written first while sites are still being downloaded)
            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            resultsWindow.Text += $"Total execution time: {elapsedMs} {Environment.NewLine}";
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

        /// <summary>
        /// Gets sites from PrepData and downloads each website, appointing each downloaded site into a WebsiteData variable, reports each result.
        /// </summary>
        private void RunDownloadSync()
        {
            List<string> websites = PrepData();

            foreach (var site in websites)
            {
                WebsiteData results = DownloadWebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        private async Task RunDownloadParallelAsync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteData>> tasks = new List<Task<WebsiteData>>();


            foreach (var website in websites)
            {
                tasks.Add(Task.Run(() => DownloadWebsite(website)));
                //WebsiteData websiteData = await Task.Run(() => DownloadWebsite(website));
                //ReportWebsiteInfo(websiteData);
            }
            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                ReportWebsiteInfo(item);
            }
        }

        private WebsiteData DownloadWebsite(string websiteUrl)
        {
            WebsiteData output = new WebsiteData();
            WebClient client = new WebClient();

            output.SiteUrl = websiteUrl;
            output.SiteData = client.DownloadString(websiteUrl);

            return output;
        }

        private void ReportWebsiteInfo(WebsiteData data)
        {
            resultsWindow.Text += $"{data.SiteUrl} downloaded: {data.SiteData.Length} characters long.{Environment.NewLine}";
        }


    }
}
