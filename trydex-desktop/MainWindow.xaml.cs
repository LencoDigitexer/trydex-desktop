using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json.Linq;
using trydex_core;


namespace trydex_desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private HttpClient httpClient;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            // Simulate search results
            var searchTerm = SearchTextBox.Text;

            Web webSearch = new Web();
            var results = webSearch.GetSearchResults();

            // Clear previous results
            ResultsStackPanel.Children.Clear();

            // Add a header with the search term
            var header = new TextBlock
            {
                Text = $"Search results for: {searchTerm}",
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(10)
            };
            ResultsStackPanel.Children.Add(header);

            // Add search results
            foreach (var result in results)
            {
                var resultPanel = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    Margin = new Thickness(10)
                };

                var link = new TextBlock
                {
                    Text = result.Link,
                    FontSize = 14,
                    FontWeight = FontWeights.Bold,
                    Foreground = SystemColors.HighlightBrush,
                    TextDecorations = TextDecorations.Underline
                };

                var iconUri = new Uri(result.IconUrl, Uri.IsWellFormedUriString(result.IconUrl, UriKind.Absolute) ? UriKind.Absolute : UriKind.Relative);
                var icon = new Image
                {
                    Source = new BitmapImage(iconUri),
                    Width = 16,
                    Height = 16,
                    Margin = new Thickness(0, 5, 0, 5)
                };
                var siteName = new TextBlock
                {
                    Text = result.SiteName,
                    FontSize = 14,
                    FontWeight = FontWeights.Bold
                };
                var description = new TextBlock
                {
                    Text = result.Description,
                    FontSize = 12
                };

                resultPanel.Children.Add(link);
                resultPanel.Children.Add(icon);
                resultPanel.Children.Add(siteName);
                resultPanel.Children.Add(description);

                var borderedResultPanel = new Border
                {
                    BorderBrush = SystemColors.ControlDarkBrush,
                    BorderThickness = new Thickness(1),
                    Padding = new Thickness(5),
                    Child = resultPanel
                };

                ResultsStackPanel.Children.Add(borderedResultPanel);
            }
        }

        private void WebButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BooksButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PicturesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        public class SearchResult
        {
            public string Link { get; set; }
            public string IconUrl { get; set; }
            public string SiteName { get; set; }
            public string Description { get; set; }
        }
    }
}
