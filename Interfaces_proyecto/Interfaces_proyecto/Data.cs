using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_proyecto
{
    class Data : DataCapsule
    {
        List<TeamData> teamList = new List<TeamData>();
        List<string> names = new List<string>();

        public void DataFetch(ListBox nameList)
        {
            if (names.Count > 0)
            {
                names.Clear();
            }
            for (int i = 0; i < nameList.Items.Count; i++)
            {
                names.Add(nameList.Items[i].ToString());
            }
        }

        public void SortNames(int members)
        {
            Random rand = new Random();
            List<string> namePool = names;
            while (namePool.Count > 0)
            {
                TeamData newTeam = new TeamData();
                for (int i = 0; i < members && namePool.Count > 0; i++)
                {
                    int j = rand.Next(0, namePool.Count - 1);
                    newTeam.Team.Add(namePool[j]);
                    namePool.RemoveAt(j);
                }
                teamList.Add(newTeam);
            }
        }

        public List<TeamData> GetTeams()
        {
            return teamList;
        }
    }
}
