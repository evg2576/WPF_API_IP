using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_API_IP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = await APIHandler.GetDataAsync("https://ipwho.is/");
            label1.Content = $"Ваш IP: {data.ip}, Вы находитесь в стране {data.country}";
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label2.Content = "Считаем до 1000...";
            label2.Content = "Посчитали, " + await ActionAsync(); // окно не подвисает
            //label2.Content = "Посчитали, " + Action(); // окно подвисает
        }

        async Task<int> ActionAsync()
        {
            int i = 0;
            await Task.Run(() =>
            {
                for (; i < 1000; i++)
                {
                    Thread.Sleep(5);
                }
            });
            return i;
        }

        int Action()
        {
            int i = 0;
            for (; i < 1000; i++)
            {
                Thread.Sleep(5);
            }
            return i;
        }
    }
}
