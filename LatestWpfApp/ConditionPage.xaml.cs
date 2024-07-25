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

namespace LatestWpfApp
{
    /// <summary>
    /// ConditionPage.xaml の相互作用ロジック
    /// </summary>
    public partial class ConditionPage : UserControl
    {
        private CallMethodControl _callMethodControl;
        public ConditionPage()
        {
            InitializeComponent();
            this._callMethodControl = new CallMethodControl();
        }

        private void CallMethodButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._callMethodControl);
        }

    }
}
