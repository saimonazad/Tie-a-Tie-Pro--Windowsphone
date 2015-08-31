using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.LocalStorage;
using AppStudio.DataProviders.Menu;
using TieATiePro;
using TieATiePro.Sections;
using TieATiePro.ViewModels;

namespace TieATiePro.Views
{
    public sealed partial class MenuListPage : PageBase
    {
        public ListViewModel<LocalStorageDataConfig, MenuSchema> ViewModel { get; set; }

        public MenuListPage()
        {
            this.ViewModel = new ListViewModel<LocalStorageDataConfig, MenuSchema>(new MenuConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
