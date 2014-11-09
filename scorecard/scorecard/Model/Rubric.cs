using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scorecard.Model
{
    public class Rubric
    {
        public Rubric()
        {
            Criteria = new ObservableCollection<string> { "Some", "Starting", "data" };
        }

        public ObservableCollection<string> Criteria { get; private set; }
    }
}
