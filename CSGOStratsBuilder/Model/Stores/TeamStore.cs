using System;

namespace CSGOStratsBuilder.Model.Stores {
    public class TeamStore
    {
        public event Action<string> TeamAdded;

        public void AddTeam(string name)
        {
            TeamAdded?.Invoke(name);
        }

        public event Action<string> TeamDeleted;

        public void DeleteTeam(string name) {
            TeamDeleted?.Invoke(name);
        }
    }
}
