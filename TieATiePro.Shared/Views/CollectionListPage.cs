using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.DynamicStorage;
using TieATiePro;
using TieATiePro.Sections;
using TieATiePro.ViewModels;

namespace TieATiePro.Views
{
    public sealed partial class CollectionListPage : PageBase
    {
        public ListViewModel<DynamicStorageDataConfig, Collection1Schema> ViewModel { get; set; }

        public CollectionListPage()
        {
            this.ViewModel = new ListViewModel<DynamicStorageDataConfig, Collection1Schema>(new CollectionConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
