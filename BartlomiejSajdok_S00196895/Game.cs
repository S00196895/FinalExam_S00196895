using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BartlomiejSajdok_S00196895
{
    public class Game
    {
        [Key]
        public string Name { get; set; }
        public double MetricScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public Game(string name, string platform, double metricScore, decimal price, string gameImage = "", string description = ""    )
        {
            Name = name;
            MetricScore = metricScore;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = gameImage;
        }

        public Game()
        {
        }

        public void DecreasePrice(decimal decrease)
        {
            Price -= decrease;
        }
    }
    //code for the database
    public class GameData : DbContext
    {
        //naming the database
        public GameData() : base("MyVideoGameData") { }

        //creating the table
        public DbSet<Game> Games { get; set; }
    }
}
