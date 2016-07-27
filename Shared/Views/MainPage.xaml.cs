using ClassRecordSystem.Models;
using ClassRecordSystem.SystemParameters.View;
using DevExpress.Xpf.WindowsUI;
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

namespace ClassRecordSystem.Shared
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        #region Loaded
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                txtSchoolName.Text = context.Settings.FirstOrDefault(c => c.Id == 1).Value;
                txtUserName.Text = Variables.UserName;
                txtAccess.Text = Variables.Access;
                switch (txtAccess.Text)
                {
                    case "Administrator":
                        stackAdmin.Visibility = Visibility.Visible;
                        btnSettings.Visibility = Visibility.Visible;
                        break;
                    case "Teacher":
                        stackTeachers.Visibility = Visibility.Visible;
                        break;
                    case "Student":
                        stackStudents.Visibility = Visibility.Visible;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        #region Logout
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            var frame = DevExpress.Xpf.Core.Native.LayoutHelper.FindParentObject<NavigationFrame>(this);
            LoginPage page = new LoginPage();
            frame.Navigate(page);
        }
        #endregion

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsPage page = new SettingsPage();
            mainFrame.Navigate(page);
        }

    }
}
