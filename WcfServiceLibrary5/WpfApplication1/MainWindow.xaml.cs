using System.Diagnostics;
using System.Windows;


namespace WpfApplication5
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


        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var proxy = new BetServiceClient();

            var persons = await proxy.GetPersonsAsync();

            foreach (var item in persons)
            {
                Debug.WriteLine($"{item.Name}: {item.Age}");
            }

        }
    }
}