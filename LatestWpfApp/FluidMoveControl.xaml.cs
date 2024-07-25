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
    /// FluidMoveControl.xaml の相互作用ロジック
    /// </summary>
    public partial class FluidMoveControl : UserControl
    {
        public FluidMoveControl()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.Height = 50;
            rect.Width = 50;
            rect.Fill = Brushes.DeepPink;
            rect.Margin = new Thickness(5.0);
            this.Panel.Children.Add(rect);
        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Panel.Children.Count > 0)
            {
                this.Panel.Children.RemoveAt(0);
            }
        }
    }
}
