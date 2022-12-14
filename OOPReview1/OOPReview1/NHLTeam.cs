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

        private const int MaxPlayers = 23;

        public NHLTeam(NHLConference conference, NHLDivision division, string name, string city, List<NHLPlayer> players) 
        {
            Name = name;
            City = city;
            _conference = conference;
            _division = division;
            Players = players;
        }

        public NHLTeam(NHLConference conference, NHLDivision division, string name, string city)
        {
            _conference = conference;
            _division = division;
            _name = name;
            _city = city;
            Players = new List<NHLPlayer>();
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
                return (Wins * 2) + OvertimeLosses;
            }
        }

        public List<NHLPlayer> Players
        {
            get; private set;
        }

        public void AddPlayer(NHLPlayer player)
        {

            if (Players.Count >= MaxPlayers)
            {
                throw new ArgumentException("The team is full!");
            }
            Players.Add(player);
        }

        public void RemovePlayer(int playerNo)
        {
            var playerSearch = Players.Where(x => x.PlayerNumber == playerNo).FirstOrDefault();
            if (playerSearch != null)
            {
                Players.Remove(playerSearch);
            } else
            {
                throw new ArgumentException("The specified player number could not be found in the team.");
            }
        }

    }
}
