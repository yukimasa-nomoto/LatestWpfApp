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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private AnimationPage animationPage;
        private ConditionPage conditionPage;
        internal MainWindowViewModel ViewModel => (MainWindowViewModel)this.DataContext;

        public MainWindow()
        {
            InitializeComponent();
            animationPage = new AnimationPage();
            conditionPage = new ConditionPage();

            this.DataContext = new MainWindowViewModel();
            this.MainContent.Children.Add(animationPage);
        }

        private void AnimationButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this.animationPage);
        }

        private void ConditionalButton_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this.conditionPage);
        }

    }
}
