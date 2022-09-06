using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview1
{
    public enum Conference
    {
        EASTERN_CONFERENCE,
        WESTERN_CONFERENCE
    }

    public enum Division
    {
        METROPOLITAN_DIVISION,
        ATLANTIC_DIVISION,
        CENTRAL_DIVISION,
        PACIFIC_DIVISION
    }

    public class Team
    {
        public Conference Conference { get; set; }
        public Division Division { get; set; }
        public string Name { get; set; }

    }
}
