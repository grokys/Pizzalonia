using System.Collections.Generic;
using Pizzalonia.Models;

namespace Pizzalonia.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public MenuViewModel(Database database)
        {
            Items = database.Menu;
        }

        public IList<Pizza> Items { get; }
    }
}
