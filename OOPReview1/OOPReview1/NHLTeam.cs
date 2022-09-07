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
        private string _city;
        private int _gamesPlayed;
        private int _wins;
        private int _losses;
        private int _overtimeLosses;
        private int _points;

        private List<NHLPlayer> _players;
        public NHLTeam(NHLConference conference, NHLDivision division, string name, string city)
        {
            _conference = conference;
            _division = division;
            _name = name;
            _city = city;
        }

        public NHLConference Conference
        {
            get { return _conference; }
        }
        public NHLDivision Division
        {
            get { return _division; }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a team name!");
                }
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _city = value;
                }
                else
                {
                    throw new ArgumentException("Please enter a city name!");
                }
            }
        }

        public int GamesPlayed { get { return _gamesPlayed; }
            set
            {
                if (value >= 0)
                {
                    _gamesPlayed = value;
                }
                else
                {
                    throw new ArgumentException("Games played cannot be negative!");
                }
            }
        }

        public int Wins
        {
            get { return _wins; }
            set
            {
                if (value >= 0)
                {
                    _wins = value;
                }
                else
                {
                    throw new ArgumentException("Wins cannot be negative!");
                }
            }
        }

        public int Losses
        {
            get { return _losses; }
            set
            {
                if (value >= 0)
                {
                    _losses = value;
                }
                else
                {
                    throw new ArgumentException("Losses cannot be negative!");
                }
            }
        }

        public int OvertimeLosses
        {
            get { return _overtimeLosses; }
            set
            {
                if (value > 0)
                {
                    _overtimeLosses = value;
                }
                else
                {
                    throw new ArgumentException("Overtime Losses cannot be negative!");
                }
            }
        }

        public int Points
        {
            get
            {
                _points = 0;
                _points += _wins * 2;
                _points += _overtimeLosses;

                return _points; 
            }
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
