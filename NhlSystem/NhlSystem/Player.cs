using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystem
{
    public class Player: Person
    {
        public Position Position { get; set; }
        public int Assists { get; set; }
        public int Goals { get; set; }
        public int PrimaryNo { get;set; }

        public int Points
        {
            get
            {
                return Goals + Assists;
            }
        }

        public Player(string fullName, Position position, int primaryNumber) : base(fullName)
        {
            Goals = 0;
            Assists = 0;
            Position = position;
            PrimaryNo = primaryNumber;
        }
        public Player(string fullName, Position position, int primaryNumber, int goals, int assists) : base(fullName)
        {
            Goals = goals;
            Assists = assists;
            Position = position;
            PrimaryNo = primaryNumber;
        }
    }

    public enum Position
    {
        LW,
        D,
        RW,
        C,
        G
    }
}
