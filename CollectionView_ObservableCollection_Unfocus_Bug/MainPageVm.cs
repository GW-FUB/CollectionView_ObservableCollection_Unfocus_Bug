using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace COUB
{
    public class MainPageVm
    {
        private readonly List<string> _allItems = new List<string> { "A", "AB", "ABC", "ABCD", "ABCDE" };
        public ObservableRangeCollection<string> Items { get; }

        public MainPageVm()
        {
            Items = new ObservableRangeCollection<string>(_allItems);
        }

        public Command SearchCommand => new Command((obj) =>
        {
            if (obj == null || obj is not string s || s.Length == 0)
            {
                Items.ReplaceAll(_allItems);
                return;
            }

            Items.ReplaceAll(_allItems.Where(x => x.Contains(s)));
        });
    }
}