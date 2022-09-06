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
        private Conference _conference;
        private Division _division;
        private string _name;

        public Team(Conference conference, Division division, string name)
        {
            _conference = conference;
            _division = division;
            _name = name;
        }

        public Conference Conference
        {
            get { return _conference; }
        }
        public Division Division
        {
            get { return _division; }
            set { _division = value; }
        }



    }
}
