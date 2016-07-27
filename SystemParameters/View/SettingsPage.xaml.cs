using ClassRecordSystem.SystemParameters.View.SettingsPageFrames;
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

namespace ClassRecordSystem.SystemParameters.View
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            lbSettings.SelectedIndex = 0;
        }

        private void SettingsFrameChanger()
        {
            if (lbSettings.SelectedIndex == 0)
            {
                General page = new General();
                SettingsFrame.Navigate(page);
            }
            else if (lbSettings.SelectedIndex == 1)
            {
                Grades page = new Grades();
                SettingsFrame.Navigate(page);
            }
            else if (lbSettings.SelectedIndex == 2)
            {
                SchoolYear page = new SchoolYear();
                SettingsFrame.Navigate(page);
            }
            else if (lbSettings.SelectedIndex == 3)
            {
                Terms page = new Terms();
                SettingsFrame.Navigate(page);
            }
        }
        private void lbSettings_SelectedIndexChanged(object sender, RoutedEventArgs e)
        {
            SettingsFrameChanger();
        }

        

        
    }
}
