using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorecard.Controller
{
    public interface IApplicationController
    {
        void Save(string fileName);

        void Exit();
    }
}
