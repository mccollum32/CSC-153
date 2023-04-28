using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public static class WorldSeries
    {
        private int CalculateNumberWon(string selectedTeam)
        {
            int count = 0;

            foreach (string team in timesWonList)
            {
                if (team == selectedTeam)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
