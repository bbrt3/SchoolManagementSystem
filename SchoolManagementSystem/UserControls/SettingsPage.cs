using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.UserControls
{
    public partial class SettingsPage : UserControl
    {
        private static SettingsPage _instance;

        public static SettingsPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SettingsPage();
                return _instance;
            }
        }

        public SettingsPage()
        {
            InitializeComponent();
        }
    }
}
