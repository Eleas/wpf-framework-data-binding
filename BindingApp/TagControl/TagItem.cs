using System.ComponentModel;
using System.Windows.Media;

namespace BindingApp.TagControl
{
    public class TagItem : INotifyPropertyChanged
    {
        private string _name;
        private SolidColorBrush _color;
        private bool _isSelected;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public SolidColorBrush Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TagItem(string name, SolidColorBrush color, bool isSelected = false)
        {
            Name = name;
            Color = color;
            IsSelected = isSelected;
        }
    }
}
