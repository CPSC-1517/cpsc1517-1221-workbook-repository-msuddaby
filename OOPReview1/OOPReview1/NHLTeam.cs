using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview1
{


    public class NHLTeam
    {
        private NHLConference _conference;
        private NHLDivision _division;
        private string _name;
        private List<NHLPlayer> _players;
        public NHLTeam(NHLConference conference, NHLDivision division, string name)
        {
            _conference = conference;
            _division = division;
            _name = name;
        }

        public NHLConference Conference
        {
            get { return _conference; }
        }
        public NHLDivision Division
        {
            get { return _division; }
            set { _division = value; }
        }

        public List<NHLPlayer> Players
        {
            get { return _players; }
        }

        public void AddPlayer(NHLPlayer player)
        {
            _players.Add(player);
        }

    }
}
