namespace OOPReview1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NHLTeam newTeam = new NHLTeam(NHLConference.WESTERN, NHLDivision.METROPOLITAN, "Bruh Moments", "Edmonton");
            NHLTeam newTeam2 = new NHLTeam(NHLConference.EASTERN, NHLDivision.METROPOLITAN, "Lightning", "IDK");

            newTeam.Wins = 33;
            newTeam.Losses = 42;
            newTeam.OvertimeLosses = 7;

            newTeam2.Wins = 51;
            newTeam2.Losses = 23;
            newTeam2.OvertimeLosses = 8;

            Console.WriteLine($"TEAM 1:\n" +
                $"\tName - {newTeam.Name}" +
                $"\tWins - {newTeam.Wins}" +
                $"\tLosses - {newTeam.Losses}" +
                $"\tOvertime Losses - {newTeam.OvertimeLosses}" +
                $"\tPOINTS - {newTeam.Points}");

            Console.WriteLine($"TEAM 2:\n" +
                $"\tName - {newTeam2.Name}" +
                $"\tWins - {newTeam2.Wins}" +
                $"\tLosses - {newTeam2.Losses}" +
                $"\tOvertime Losses - {newTeam2.OvertimeLosses}" +
                $"\tPOINTS - {newTeam2.Points}");

        }
    }
}