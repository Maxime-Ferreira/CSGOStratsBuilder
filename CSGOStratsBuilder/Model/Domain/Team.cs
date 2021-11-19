using System.Collections.Generic;

namespace CSGOStratsBuilder.Model.Domain {
    public class Team {
        public Team(string name, List<Player> players) {
            Name = name;
            Players = players;
        }

        public string Name { get; set; }

        public List<Player> Players { get; set; }

        public List<Strategy> Strategies { get; set; }
    }
}
