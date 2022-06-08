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
using vcids.Classes;
using vcids.Models;

namespace vcids.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageSignUp.xaml
    /// </summary>
    public partial class PageSignUp : Page
    {
        public PageSignUp()
        {
            InitializeComponent();
        }

        private void BtnSignIUAdmin_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder erros = new StringBuilder();

            if (String.IsNullOrEmpty(Login.Text))
                erros.AppendLine("Введите логин");
            else if (String.IsNullOrEmpty(Password.Password))
                erros.AppendLine("Введите пароль");

            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
                return;
            }

            try
            {
                var user = new Users();
                user.Login = Login.Text;
                user.Password = Password.Password;
                user.IdPremission = 2;
                CarPlanEntities.GetContext().Users.Add(user);
                CarPlanEntities.GetContext().SaveChanges();
                MessageBox.Show(Login.Text + " Вы успешно зарегистрировались, теперь войдите в аккаунт");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            NavManager.MainFrame.Navigate(new SignIn());
        }
    }
}
