using Hardcodet.Wpf.TaskbarNotification;
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

namespace WPFNotificationSample
{
    /// <summary>
    /// NotificationItem1.xaml 的互動邏輯
    /// </summary>
    public partial class NotificationItem1 : UserControl
    {
        public NotificationItem1()
        {
            InitializeComponent();
            TaskbarIcon.AddBalloonClosingHandler(btnClose, btnClose_Click);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true; 
            TaskbarIcon taskbarIcon = TaskbarIcon.GetParentTaskbarIcon(this);
            taskbarIcon.CloseBalloon();
        }
    }
}
