using vcids.Classes;
using vcids.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace vcids.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }



        private void BtnSignInAdmin_Click(object sender, RoutedEventArgs e)
        {
            var user =  CarPlanEntities.GetContext().Users.ToList();


            if (ApplicationConfig.IsDev)
            {
                user = user.Where(p => p.Login.ToLower().Contains("admin".ToLower())).ToList();
                user = user.Where(p => p.Password.ToLower().Contains("1234".ToLower())).ToList();
            }
            else
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

                user = user.Where(p => p.Login.ToLower().Contains(Login.Text.ToLower())).ToList();
                user = user.Where(p => p.Password.ToLower().Contains(Password.Password.ToLower())).ToList();
            }

            Users searchuser = user.FirstOrDefault();
            if (searchuser == null)
            {
                MessageBox.Show("Наверный логин или пароль", "внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            CurrentUser.PermissionName = searchuser.Permissions.Name;
            CurrentUser.Id = searchuser.Id;

            if(searchuser.IdPremission == 1)
            {
                NavManager.MainFrame.Navigate(new PageUsers());
            }
            else
            {
                NavManager.MainFrame.Navigate(new Account());
            }
            
        }

        private void BtnSignInUser_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnSignIUAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageSignUp());
        }
    }
}
