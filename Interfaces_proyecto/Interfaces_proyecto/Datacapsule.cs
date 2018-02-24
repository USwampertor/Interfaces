using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_proyecto
{
    interface DataCapsule
    {
        void DataFetch(ListBox nameList);
        void SortNames(int members);
        List<TeamData> GetTeams();
    }
}
