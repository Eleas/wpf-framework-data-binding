using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace BindingApp.TagControl
{
    /// <summary>
    /// Interaction logic for TagControl.xaml
    /// </summary>
    public partial class TagControl : Window
    {
        private ObservableCollection<TagItem> _items;

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

        public TagControl(Window parentWindow)
        {
            parentWindow.Closed += (s, e) => Close();
            Topmost = true;
            InitializeComponent();

            // Make empty collection exist.
            Items = CreateTagItemList();

            // Add the data for the item control.
            lvDataBinding.ItemsSource = Items;
        }

        // Expose datamodel to XAML.
        public ObservableCollection<TagItem> Items { get => _items; set => _items = value; }
    }
}
