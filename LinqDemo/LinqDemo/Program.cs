using static System.Console;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create list of games >:)
            var games = new List<VideoGame>
            {
                new("Hotline Miami", "PC", 39.99, Guid.NewGuid()),
                new("Minecraft", "PC", 29.99, Guid.NewGuid()),
                new("TES V: Skyrim", "PS4", 49.99, Guid.NewGuid()),
                new("Mario 64", "Nintendo 64", 29.99, Guid.NewGuid()),
                new("Call of Duty: Advanced Warfare", "Xbox One", 79.99, Guid.NewGuid()),
                new("Fallout 4", "PS4", 79.99, Guid.NewGuid()),
                new("Overwatch Legendary Edition", "Nintendo",34.99,Guid.NewGuid()),
                new("WWE 2K20", "PS4", 39.99, Guid.NewGuid()),
                new("WWE 2K20", "Xbox One", 39.99, Guid.NewGuid()),
                new("Kingdom Hearts 3", "Xbox One", 34.99, Guid.NewGuid()),
                new("Dragon Quest Builders 2", "PS4", 29.99, Guid.NewGuid())
            };



            //foreach (var game in games.Where(x => x.Price > 70).ToList())
            //{
            //    WriteLine(game);
            //}

            //games.ForEach(currentGame => {
            //    WriteLine(currentGame);
            //    }
            //);

            //games.Where(currentGame => currentGame.Platform == "Nintendo")
            //    .ToList()
            //    .ForEach(currentGame => WriteLine(currentGame));

            //var nintendoGameQuery = from currentGame in games
            //                        where currentGame.Platform == "Nintendo"
            //                        select currentGame;

            //foreach (var game in nintendoGameQuery)
            //{
            //    WriteLine(game);
            //}

            //Print just the Title of each videogame

            //games.ForEach(x => WriteLine(x.Title));

            games.Select(x => x.Title)
                .ToList()
                .ForEach(x => WriteLine(x));
            // distinct game platforms
            games.Select(x => x.Platform)
                .Distinct()
                .ToList()
                .ForEach(x => WriteLine(x));

            //Sum all the nintendo games
            WriteLine(games.Where(x => x.Platform == "PS4")
                            .Count());

            var sum = games.Where(x => x.Platform == "PS4")
                                .Sum(x => x.Price);
            WriteLine(sum);
        }
    }
}