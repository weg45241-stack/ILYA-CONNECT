using System.Diagnostics;
using System.Windows;
namespace ILYA_CONNECT;
public partial class MainWindow : Window
{
    private int _profiles;
    public MainWindow() => InitializeComponent();
    private void Count(string service, string slot)
    {
        _profiles++;
        Counter.Text = $"{_profiles} профилей открыто (это не проверка входа)";
        if (service == "Telegram")
            TelegramStatus.Text = $"{slot}: профиль браузера открыт";
        else
            DiscordStatus.Text = $"{slot}: профиль браузера открыт";
    }
    private static void Open(string url) =>
        Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
    private void TelegramMain_Click(object sender, RoutedEventArgs e)
    { Open("https://web.telegram.org/"); Count("Telegram", "Основной"); }
    private void TelegramSecond_Click(object sender, RoutedEventArgs e)
    { Open("https://web.telegram.org/"); Count("Telegram", "Второй"); }
    private void DiscordMain_Click(object sender, RoutedEventArgs e)
    { Open("https://discord.com/app"); Count("Discord", "Основной"); }
    private void DiscordSecond_Click(object sender, RoutedEventArgs e)
    { Open("https://discord.com/app"); Count("Discord", "Второй"); }
}
