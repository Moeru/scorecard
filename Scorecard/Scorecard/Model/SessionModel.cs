using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard.Model
{
    public class SessionModel
    {
        public SessionModel()
        {
            Categories = new List<Category>();
            Judges = new List<Judge>();
            Contributors = new List<Contributor>();
            Submissions = new List<Submission>();
        }

        public List<Category> Categories { get; private set; }
        public List<Judge> Judges { get; private set; }
        public List<Contributor> Contributors { get; private set; }
        public List<Submission> Submissions { get; private set; }
    }
}
