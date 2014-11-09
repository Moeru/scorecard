using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard.Model
{
    public class Rubric
    {
        public Rubric()
        {
            Criteria = new List<string> { "Some", "Starting", "data" };
        }

        public List<string> Criteria { get; private set; }
    }
}
