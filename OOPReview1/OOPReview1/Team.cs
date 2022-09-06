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
        private Conference Conference;
        private Division Division;
        private string Name;

        public Team(Conference conference, Division division, string name)
        {
            Conference = conference;
            Division = division;
            Name = name;
        }

        public void SetConference(Conference conference)
        {
            Conference = conference;

        }

        public Conference GetConference()
        {
            return Conference;
        }

        public void SetDivision(Division division)
        {
            Division = division;
        }

        public Division GetDivision()
        {
            return Division;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                throw new Exception("You must enter a name for the team!");
            }
        }

        public string GetName()
        {
            return Name;
        }

    }
}
