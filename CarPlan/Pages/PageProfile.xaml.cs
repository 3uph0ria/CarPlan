using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для PageProfile.xaml
    /// </summary>
    public partial class PageProfile : Page
    {
        public static int IdUser1Tmp = 0;
        public PageProfile(int IdUser1)
        {
            InitializeComponent();
            IdUser1Tmp = IdUser1;
            var profiles = CarPlanEntities.GetContext().FeedBack.ToList();
            profiles = profiles.Where(p => Convert.ToString(p.IdUser1).Contains(Convert.ToString(IdUser1))).ToList();

            var users = CarPlanEntities.GetContext().Users.ToList();
            users = users.Where(p => p.Id == IdUser1Tmp).ToList();
            var user = users.LastOrDefault();

            Header.Text =  "Отзывы пользователя " + user.Login;


            ListServices.ItemsSource = profiles;
        }

        private void BtnAddFeddBack_Click(object sender, RoutedEventArgs e)
        {


            if (IdUser1Tmp == CurrentUser.Id)
            {
                MessageBox.Show("Нельзя оставить отзыв самому себе");
                return;
            }

            var newFeedBack = new FeedBack();
            newFeedBack.IdUser1 = IdUser1Tmp;
            newFeedBack.IdUser2 = CurrentUser.Id;
            newFeedBack.Date = DateTime.Now;
            newFeedBack.Text = FeedBackText.Text;

            try
            {
               

                CarPlanEntities.GetContext().FeedBack.Add(newFeedBack);
                CarPlanEntities.GetContext().SaveChanges();
                MessageBox.Show("Отзыв успешно добавлен");
                NavManager.MainFrame.Navigate(new PageProfile(IdUser1Tmp));
            }
            catch (DbEntityValidationException ex)
            {
                if (ApplicationConfig.IsDev)
                {
                    foreach (var errors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in errors.ValidationErrors)
                        {
                            MessageBox.Show(validationError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Произошла ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageAdwerts());
        }
    }
}
