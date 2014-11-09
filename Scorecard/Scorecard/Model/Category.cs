using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard.Model
{
    public class Category
    {
        public Category()
        {
            Rubric = new Rubric();
        }

        public string Name { get; private set; }

        public Rubric Rubric { get; private set; }
    }
}
