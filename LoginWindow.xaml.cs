using AsliPehlivan_HW5.Service;
using System.Windows;

namespace AsliPehlivan_HW5
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            CetUserService cetUserService = new CetUserService();
            //txtPassword.Text=cetUserService.hashPassword("admin");
            var loginUser = cetUserService.Login(txtUserName.Text, txtPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else
            {
                /// Doğru giriş yapıldı.
                MainWindow mainWindow = new MainWindow(loginUser);
                mainWindow.Show();
                this.Close();
            }
        }
    }
}
