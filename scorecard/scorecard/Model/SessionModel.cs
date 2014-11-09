using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scorecard.Model
{
    public class SessionModel
    {
        public SessionModel()
        {
            Categories = new ObservableCollection<Category>();
            Judges = new ObservableCollection<Judge>();
            Contributors = new ObservableCollection<Contributor>();
            Submissions = new ObservableCollection<Submission>();
        }

        public ObservableCollection<Category> Categories { get; private set; }
        public ObservableCollection<Judge> Judges { get; private set; }
        public ObservableCollection<Contributor> Contributors { get; private set; }
        public ObservableCollection<Submission> Submissions { get; private set; }
    }
}
