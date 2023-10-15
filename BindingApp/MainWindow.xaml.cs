using System.Windows;

namespace BindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TagControl.TagControl TagControl;

        public MainWindow()
        {
            InitializeComponent();
            TagControl = new TagControl.TagControl(this);

            TagControl.Show();
        }
    }
}
