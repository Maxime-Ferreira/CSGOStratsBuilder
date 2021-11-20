using System;
using System.Collections.Generic;
using System.Text;

namespace CSGOStratsBuilder.Model.Stores
{
    public class TeamStore
    {
        public event Action<string> TeamAdded;

        public void AddTeam(string name)
        {
            TeamAdded?.Invoke(name);
        }
    }
}
