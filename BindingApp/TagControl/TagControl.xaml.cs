using System.Windows;

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
    }
}
