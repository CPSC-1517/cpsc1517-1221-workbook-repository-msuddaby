using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview1
{
    public class NHLPlayer
    {
        private int _playerNumber;
        private string _playerName;
        private NHLTeam _playerTeam;

        public NHLPlayer (int playerNumber, string playerName, NHLTeam playerTeam)
        {
            _playerNumber = playerNumber;
            _playerName = playerName;
            _playerTeam = playerTeam;
        }

        public int PlayerNumber
        {
            get { return _playerNumber; }
            set { _playerNumber = value; }
        }

        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public NHLTeam PlayerTeam
        {
            get { return _playerTeam; }
            set { _playerTeam = value; }
        }


    }
}
