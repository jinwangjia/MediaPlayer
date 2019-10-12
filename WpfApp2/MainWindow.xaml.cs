using System;
using System.Windows;
using System.Windows.Media;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer player = new MediaPlayer();
            player.Open(new Uri($"{AppContext.BaseDirectory}\\Resources\\8773.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }
    }
}
