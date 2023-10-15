using System.Windows.Media;

namespace BindingApp.TagControl
{
    public class TagItem
    {
        public TagItem(string name, SolidColorBrush color, bool isSelected = false)
        {
            Name = name;
            Color = color;
            IsSelected = isSelected;
        }

        public string Name { get; set; }
        public SolidColorBrush Color { get; set; }
        public bool IsSelected { get; set; } = false;
    }
}
