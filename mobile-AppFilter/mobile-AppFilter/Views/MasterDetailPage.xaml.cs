using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using mobile_AppFilter.Models;
using mobile_AppFilter.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace mobile_AppFilter.Views
{
    public sealed partial class MasterDetailPage : Page, INotifyPropertyChanged
    {
        private SampleModel _selected;
        public SampleModel Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleModel> SampleItems { get; private set; } = new ObservableCollection<SampleModel>();

        public MasterDetailPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync() 
        {
            SampleItems.Clear(); 

            var service = new SampleModelService(); 
            var data = await service.GetDataAsync(); 

            foreach (var item in data) 
            {
                SampleItems.Add(item); 
            }
            Selected = SampleItems.First(); 
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e?.ClickedItem as SampleModel;
            if (item != null)
            {
                if (WindowStates.CurrentState == NarrowState)
                {
                    NavigationService.Navigate<Views.MasterDetailDetailPage>(item);
                }
                else
                {
                    Selected = item;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
