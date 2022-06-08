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
    /// Логика взаимодействия для PageBusiness.xaml
    /// </summary>
    public partial class PageBusiness : Page
    {
        public PageBusiness()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new Account());
        }

        private void BtnBy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var users = CarPlanEntities.GetContext().Users.ToList();
                users = users.Where(p => Convert.ToString(p.Id).Contains(Convert.ToString(CurrentUser.Id))).ToList();
                var user = users.LastOrDefault();

                if(user.IdPremission == 3)
                {
                    MessageBox.Show("вы уже купили бизнес аккаунт");
                    return;
                }

                user.IdPremission = 3;

                Sales sale = new Sales();
                sale.IdUser = CurrentUser.Id;
                sale.Date = DateTime.Now;

                CarPlanEntities.GetContext().Sales.Add(sale);

               CarPlanEntities.GetContext().SaveChanges();

               MessageBox.Show("Вы успешно купили бизнес аккаунт");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
