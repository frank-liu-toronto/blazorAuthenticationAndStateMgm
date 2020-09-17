using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Store
{
    public class CountStore : INotifyPropertyChanged
    {
        public class CountState
        {
            public CountState(int count)
            {
                Count = count;
            }

            public int Count { get; }
        }

        public CountStore()
        {
            this.State = new CountState(0);
        }        

        public CountState State { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyStateChanged(string actionName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Increase"));
        }

        public async Task Increase(CountState state)
        {
            await Task.Run(() =>
            {
                var count = state.Count + 1;
                this.State = new CountState(count);                
            });
            NotifyStateChanged("Increase");
        }

        public async Task Decrease(CountState state)
        {
            await Task.Run(() =>
            {
                var count = state.Count - 1;
                Thread.Sleep(5000);
                this.State = new CountState(count);                
            });
            NotifyStateChanged("Increase");
        }

    }
    
}
