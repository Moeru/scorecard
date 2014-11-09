using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scorecard.Model
{
    public class Category : INotifyPropertyChanged
    {
        private string _name;

        public Category()
        {
            Rubric = new Rubric();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value; NotifyPropertyChanged("Name");
            }
        }

        public Rubric Rubric { get; private set; }


    }
}
