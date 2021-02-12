using Xamarin.Forms;

namespace COUB
{
    public partial class MainPage : ContentPage
    {
        public MainPageVm Vm { get; }

        public MainPage()
        {
            InitializeComponent();

            BindingContext = Vm = new MainPageVm();
        }

        private void EntrySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Vm.SearchCommand.Execute(e.NewTextValue);
        }

        private void EntrySearch_Unfocused(object sender, FocusEventArgs e)
        {
            // Read stacktrace here
        }
    }
}