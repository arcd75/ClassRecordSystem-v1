using ClassRecordSystem.Models;
using DevExpress.Xpf.Core;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        #region Loaded Event
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            txtUser.Focus();
            btnLogin.IsDefault = true;
        }
        #endregion

        #region LoginMethod
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            btnLogin.IsEnabled = false;
            Login();
            
        }
        private void Login()
        {
            using (var context = new DatabaseContext())
            {
                if (txtUser.Text == "")
                {
                    DXMessageBox.Show("No username entered", "", MessageBoxButton.OK, MessageBoxImage.Stop);
                    txtUser.Focus();
                }
                else if(txtPass.Text == "")
                {
                    DXMessageBox.Show("No password entered", "", MessageBoxButton.OK, MessageBoxImage.Stop);
                    txtPass.Focus();
                }
                else if (context.Users.Where(c => c.Name == txtUser.Text).Count() == 0)
                {
                    DXMessageBox.Show("The username entered is not found within the database", "", MessageBoxButton.OK, MessageBoxImage.Stop);
                    txtUser.Focus();
                }
                else if (context.Users.Where(c => c.Name == txtUser.Text && c.Password == txtPass.Text).Count() == 0)
                {
                    DXMessageBox.Show("The username-password combination you entered is not valid", "", MessageBoxButton.OK, MessageBoxImage.Stop);
                    txtUser.Focus();
                }
                else
                {
                    var User = context.Users.FirstOrDefault(c => c.Name == txtUser.Text && c.Password == txtPass.Text);
                    Variables.UserName = User.Name;
                    Variables.Access = User.Access;
                    var frame = DevExpress.Xpf.Core.Native.LayoutHelper.FindParentObject<NavigationFrame>(this);
                    MainPage page = new MainPage();
                    frame.Navigate(page);
                }
                btnLogin.IsEnabled = true;
                
            }
        }
        #endregion



        
    }
}
