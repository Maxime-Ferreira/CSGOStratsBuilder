using CSGOStratsBuilder.Model.Domain;
using System;

namespace CSGOStratsBuilder.Model.Stores {
    public class ConfigStore {
        private Team _team;
        public Team CurrentTeam {
            get => _team;
            set {
                _team = value;
                CurrentTeamAdded?.Invoke();
            }
        }

        public event Action CurrentTeamAdded;
    }
}
