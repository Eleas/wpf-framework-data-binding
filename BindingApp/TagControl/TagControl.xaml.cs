using System.Windows;
using System.Windows.Input;

namespace BindingApp.TagControl
{
    /// <summary>
    /// Interaction logic for TagControl.xaml
    /// </summary>
    public partial class TagControl : Window
    {

        public TagControl(Window parentWindow)
        {
            parentWindow.Closed += (s, e) => Close();
            Topmost = true;
            InitializeComponent();
        }

        private void WrapPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement element && element.DataContext is TagItem tagItem)
            {
                var viewModel = (TagControlViewModel)DataContext;
                viewModel.ItemSelected(tagItem);
            }
        }
    }
}
