using Pizzalonia.Models;
using ReactiveUI;

namespace Pizzalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        readonly Database database;
        ViewModelBase currentPage;

        public MainWindowViewModel()
        {
            database = new Database();
            currentPage = new MenuViewModel(database);
        }

        public ViewModelBase CurrentPage
        {
            get { return currentPage; }
            private set { this.RaiseAndSetIfChanged(ref currentPage, value); }
        }
    }
}
