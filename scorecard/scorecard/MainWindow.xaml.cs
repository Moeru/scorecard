using Microsoft.Win32;
using Newtonsoft.Json;
using scorecard.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        private void NewFile(object sender, RoutedEventArgs e)
        {
            _sessionModel = new SessionModel();
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

    }
}
