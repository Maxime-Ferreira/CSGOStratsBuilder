using System;
using System.Collections.Generic;
using System.Text;

namespace CSGOStratsBuilder.ViewModels {
    public class TeamViewModel : BaseViewModel {
        public string Name { get; }

        public TeamViewModel(string name) {
            Name = name;
        }
    }
}
