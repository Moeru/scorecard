using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scorecard.Controller
{
    public class ApplicationController : IApplicationController
    {
        void IApplicationController.Save(string fileName)
        {
            using (var streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Create)))
            {
                //streamWriter.Write(JsonConvert.SerializeObject(_sessionModel, Formatting.Indented));
            }
        }

        void IApplicationController.Exit()
        {
            Application.Exit();
        }
    }
}
