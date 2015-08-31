using System;
using System.Collections.Generic;
using AppStudio.Common;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.DynamicStorage;
using Windows.Storage;
using TieATiePro.Config;
using TieATiePro.ViewModels;

namespace TieATiePro.Sections
{
    public class CollectionConfig : SectionConfigBase<DynamicStorageDataConfig, Collection1Schema>
    {
        public override DataProviderBase<DynamicStorageDataConfig, Collection1Schema> DataProvider
        {
            get
            {
                return new DynamicStorageDataProvider<Collection1Schema>();
            }
        }

        public override DynamicStorageDataConfig Config
        {
            get
            {
                return new DynamicStorageDataConfig
                {
                    Url = new Uri("http://ds.winappstudio.com/api/data/collection?dataRowListId=d99cebc3-0472-482b-b714-626029698a31&appId=6e09dc9b-7eb0-43f8-b6a9-6a18e1dd5095"),
                    AppId = "6e09dc9b-7eb0-43f8-b6a9-6a18e1dd5095",
                    StoreId = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.StoreId] as string,
                    DeviceType = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.DeviceType] as string
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("CollectionListPage");
            }
        }

        public override ListPageConfig<Collection1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<Collection1Schema>
                {
                    Title = "Collection",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.main_title.ToSafeString();
                        viewModel.SubTitle = item.main_description.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.main_image.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("CollectionDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<Collection1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, Collection1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Step 1";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub1.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "step 2";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub2.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Step 3";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub3.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Step 4";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub4.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Step 5";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub5.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Step 6";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub6.ToSafeString();
                    viewModel.Content = null;
                });
                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Step 7";
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.sub7.ToSafeString();
                    viewModel.Content = null;
                });


                var actions = new List<ActionConfig<Collection1Schema>>
				{
				};

                return new DetailPageConfig<Collection1Schema>
                {
                    Title = "Collection",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "Collection"; }
        }

    }
}
