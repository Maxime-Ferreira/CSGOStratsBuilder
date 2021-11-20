using System;

namespace CSGOStratsBuilder.Model.Stores {
    public class TeamStore
    {
        public event Action<string> TeamAdded;

        public void AddTeam(string name)
        {
            TeamAdded?.Invoke(name);
        }
    }
}
