using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestWpfApp
{
    internal class MainWindowViewModel : ViewModelBase
    {
        // コンボの選択中の項目のindex
        public int MySelectedIndex { get; set; }

        private List<string> _myComboItemList = new List<string>() { "aaa", "bbb", "ccc" };
        public List<string> MyComboItemList
        {
            get { return _myComboItemList; }
            set { _myComboItemList = value; SetProperty(ref _myComboItemList, value);}
        }

        public void ButtonClick()
        {

        }

        public void ComboChanged()
        {

        }
    }
}
