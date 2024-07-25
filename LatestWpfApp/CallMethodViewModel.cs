using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestWpfApp
{
    internal class CallMethodViewModel : ViewModelBase
    {
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }
        private int _count = 0;

        public void IncrementCount()
        {
            Count++;
        }
    }

}
