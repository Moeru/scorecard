using Scorecard.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scorecard.View
{
    public partial class MainWindow : Form
    {
        private readonly IApplicationController _applicationController;

        public MainWindow(IApplicationController applicationController)
        {
            _applicationController = applicationController;

            InitializeComponent();
        }

        private void uxExitMenuItem_Click(object sender, EventArgs e)
        {
            _applicationController.Exit();
        }

        private void uxOpenMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "JSON Documents (.json)|*.json";

                var result = dialog.ShowDialog();

                //if (result == System.Windows.Forms.DialogResult.)
                //{
                //    _sessionModel = JsonConvert.DeserializeObject<SessionModel>(File.ReadAllText(dialog.FileName));
                //    BindControls();
                //}

            }
        }

        private void uxSaveMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.FileName = "Results";
            dialog.DefaultExt = ".json";
            dialog.Filter = "JSON Documents (.json)|*.json";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _applicationController.Save(dialog.FileName);
            }
        }
    }
}
