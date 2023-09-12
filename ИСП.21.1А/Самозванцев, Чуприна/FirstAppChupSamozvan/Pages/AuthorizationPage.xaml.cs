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

namespace FirstAppChupSamozvan.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            if (tboxLogin.Text.Length >= 4 && pboxPassword.Password.Length >= 4)
            {
                try
                {
                    var user = Helper.dbConnect.Users.FirstOrDefault(x => x.UName == tboxLogin.Text && x.UPassword == pboxPassword.Password);

                    if (user != null)
                    {
                        MessageBox.Show($"Пользователь {tboxLogin.Text} авторизован");
                    }
                    else
                    {
                        MessageBox.Show($"Плоьзователь с такими данными не обнаружен \n Попробуйте другие данные");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            else 
            {
                MessageBox.Show("Логин и пароль меньше 4х символов");
            }
        }

        private void btnToReg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
