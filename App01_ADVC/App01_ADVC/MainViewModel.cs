using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Extended;

namespace App01_ADVC
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isBusy;
        private const int PageSize = 10;
        readonly DataService _dataService = new DataService();

        public InfiniteScrollCollection<string> Items { get; }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Items = new InfiniteScrollCollection<string>
            {
                  OnLoadMore = async () =>
                  {
                      IsBusy = true;

                      var page = Items.Count / PageSize;

                      var items = await _dataService.GetItemsAsync(page, PageSize);

                      IsBusy = false;
                      return items;
                  },
                  OnCanLoadMore = () =>
                  {
                      return Items.Count < 60;
                  }
            };
            DownloadDataAsync();
        }

        private async Task DownloadDataAsync()
        {
            var items = await _dataService.GetItemsAsync(pageIndex: 0, pageSize: PageSize);

            Items.AddRange(items);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
