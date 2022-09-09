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
        private PlayerPosition _playerPosition;

        private const int MinPlayerNumber = 0;
        private const int MaxPlayerNumber = 98;

        public NHLPlayer (int playerNumber, string playerName, PlayerPosition playerPosition)
        {
            PlayerNumber = playerNumber;
            PlayerName = playerName;
            PlayerPosition = playerPosition;
        }


        public int PlayerNumber
        {
            get { return _playerNumber; }
            set
            {
                if (value < MinPlayerNumber || value > MaxPlayerNumber)
                {
                    _playerNumber = value;
                }
            }
        }

        public string PlayerName
        {
            get { return _playerName; }
            set { 
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _playerName = value;
                }
                else
                {
                    throw new ArgumentException("The player's name cannot be empty!");
                }
            }
        }

        public PlayerPosition PlayerPosition
        {
            get { return _playerPosition; }
            set { _playerPosition = value; }
        }

        public override string ToString()
        {
            return $"{PlayerName},{PlayerNumber},{PlayerPosition}";
        }


    }
}
