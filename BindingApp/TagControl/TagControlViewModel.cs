using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace BindingApp.TagControl
{
    public class TagControlViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TagItem> _items;

        public ObservableCollection<TagItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged(nameof(TagItem));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Build the list of tag items.
        private ObservableCollection<TagItem> CreateTagItemList()
        {
            var items = new ObservableCollection<TagItem>
            {
                new TagItem("Cool tag", new SolidColorBrush(Colors.DarkBlue)),
                new TagItem("Strange tag", new SolidColorBrush(Colors.Crimson)),
                new TagItem("Lepton", new SolidColorBrush(Colors.Chartreuse))
            };
            return items;
        }

        public TagControlViewModel()
        {
            // Make empty collection exist.
            Items = CreateTagItemList();
        }
    }
}
