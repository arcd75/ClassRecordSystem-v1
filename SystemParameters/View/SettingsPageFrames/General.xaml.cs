using ClassRecordSystem.Models;
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

namespace ClassRecordSystem.SystemParameters.View.SettingsPageFrames
{
    /// <summary>
    /// Interaction logic for General.xaml
    /// </summary>
    public partial class General : UserControl
    {
        public General()
        {
            InitializeComponent();
        }
        #region Loaded
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                txtSchoolName.Text = context.Settings.FirstOrDefault(c => c.Id == 1).Value;
            }
        }
        #endregion
        #region EditSchoolName
        private void txtSchoolName_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            string SchoolName = txtSchoolName.Text;
            Task.Factory.StartNew(() =>
                {
                    using (var context = new DatabaseContext())
                    {
                        var SchoolNameSetting = context.Settings.FirstOrDefault(c => c.Id == 1);
                        SchoolNameSetting.Value = SchoolName;
                        context.SaveChanges();
                    }
                    }).ContinueWith((task) =>
                    {
                    }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        #endregion

    }
}
