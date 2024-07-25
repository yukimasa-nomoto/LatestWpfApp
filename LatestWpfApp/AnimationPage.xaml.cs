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
using System.Windows.Shapes;

namespace LatestWpfApp
{
    /// <summary>
    /// AnimationPage.xaml の相互作用ロジック
    /// </summary>
    public partial class AnimationPage : UserControl
    {
        private ControlStoryboardControl _controlStoryboard;
        private FluidMoveControl _fluidMoveControl;
        private MouseDragElementControl _mouseDragElementControl;
        private FluidMoveSetTagControl _fluidMoveSetTagControl;
        private TouchBehaviorControl _touchBehaviorControl;

        public AnimationPage()
        {
            this._controlStoryboard = new ControlStoryboardControl();
            this._fluidMoveControl = new FluidMoveControl();
            this._mouseDragElementControl = new MouseDragElementControl();
            this._fluidMoveSetTagControl = new FluidMoveSetTagControl();
            this._touchBehaviorControl = new TouchBehaviorControl();
            InitializeComponent();
        }

        private void ControlStoryboardAction_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._controlStoryboard);
        }

        private void FluidMoveBehavior_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._fluidMoveControl);
        }
        private void MouseDragElementBehavior_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._mouseDragElementControl);
        }
        private void FluidMoveSetTagBehavior_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._fluidMoveSetTagControl);
        }
        private void TranslateZoomRotateBehavior_Click(object sender, RoutedEventArgs e)
        {
            this.MainContent.Children.Clear();
            this.MainContent.Children.Add(this._touchBehaviorControl);
        }


    }
}
