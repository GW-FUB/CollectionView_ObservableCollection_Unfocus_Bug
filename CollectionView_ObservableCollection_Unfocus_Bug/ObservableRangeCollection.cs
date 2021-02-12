using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace COUB
{
    public class ObservableRangeCollection<T> : ObservableCollection<T>
    {
        public ObservableRangeCollection(IEnumerable<T> allItems) : base(allItems)
        {
        }

        /// <summary>
        /// Replaces all current items with the given range.
        /// </summary>
        /// <see cref="https://stackoverflow.com/a/13303245/4751920"/>
        public void ReplaceAll(IEnumerable<T> range)
        {
            Items.Clear();

            foreach (var item in range)
            {
                Items.Add(item);
            }

            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
            OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}