namespace OOPReview1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NHLTeam newTeam = new NHLTeam(NHLConference.WESTERN, NHLDivision.METROPOLITAN, "Bruh Moments", "Edmonton");

            newTeam.Wins = 28;
            newTeam.OvertimeLosses = 5;

            Console.WriteLine(newTeam.Points);
        }
    }
}