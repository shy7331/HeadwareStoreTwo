using HardwareStore.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
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

namespace HardwareStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserControlPAge.xaml
    /// </summary>
    public partial class UserControlPAge : Page
    {
        public UserControlPAge()
        {
            InitializeComponent();
            var services = App.db.Product.ToList();
            foreach (var service in services)
            {
                ServiceWrapPanel.Children.Add(
                    new UserControl1(
                    service.Title,
                   $"{service.Cost: 0.00}",
                    $"{service.AvgMark: 0.00}",
                    $"{service.SumOfReviews} Отзывы",
                    service.CostWithDiscount,
                    service.CostVisiblity,
                    service.TextDiscount
                    )
                );
            }
    }
}
    }
