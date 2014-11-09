using Microsoft.Win32;
using Newtonsoft.Json;
using scorecard.Model;
using System.IO;
using System.Windows;

namespace scorecard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SessionModel _sessionModel;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            var category = new Category();
            category.Name = "Default";

            _sessionModel = new SessionModel();
            _sessionModel.Categories.Add(category);
            BindControls();
        }

        private void NewFile(object sender, RoutedEventArgs e)
        {
            var category = new Category();
            category.Name = "Someone";

            _sessionModel = new SessionModel();
            _sessionModel.Categories.Add(category);
            BindControls();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "JSON Documents (.json)|*.json";

            var result = dialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                _sessionModel = JsonConvert.DeserializeObject<SessionModel>(File.ReadAllText(dialog.FileName));
                BindControls();
            }
        }

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "Results";
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON Documents (.json)|*.json";

            var result = dialog.ShowDialog();

            if (result.HasValue && result.Value)
            {
                using (var streamWriter = new StreamWriter(new FileStream(dialog.FileName, FileMode.Create)))
                {
                    streamWriter.Write(JsonConvert.SerializeObject(_sessionModel, Formatting.Indented));
                }
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BindControls()
        {
            CategoriesListBox.ItemsSource = _sessionModel.Categories;
        }

        private void AddCategory(object sender, RoutedEventArgs e)
        {
            var category = new Category();
            _sessionModel.Categories.Add(category);
        }
    }
}
