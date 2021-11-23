namespace CSGOStratsBuilder.Model.Domain {
    public class Player {

        public Player(string name, RoleT roleT, RoleCT roleCT) {
            Name = name;
            RoleT = roleT;
            RoleCT = roleCT;
        }

        public string Name { get; set; }

        public RoleT RoleT { get; set; }

        public RoleCT RoleCT { get; set; }
    }
}
