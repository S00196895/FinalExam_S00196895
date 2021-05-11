using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlomiejSajdok_S00196895
{
    public class Game
    {
        public string Name { get; set; }
        public double MetricScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public Game(string name, double metricScore, decimal price, string description = "", string platform = "",  string gameImage = "" )
        {
            Name = name;
            MetricScore = metricScore;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = gameImage;
        }
        public void DecreasePrice(decimal decrease)
        {
            Price -= decrease;
        }
    }
}
