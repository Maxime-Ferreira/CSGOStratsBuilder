using CSGOStratsBuilder.Model.Domain;
using CSGOStratsBuilder.Model.XmlManagement;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CSGOStratsBuilder.Model.UseCase {
    public class CreateConfigurationTeam {

        XMLManagement xmlManagement = XMLManagement.Instance;

        public void CreateConfigFile(string url, string teamName) {
            xmlManagement.CreateFile(url, teamName);
        }

        public Team CreateTeam(string url, string teamName, List<string> comboBoxesT, List<string> comboBoxesCT, List<string> playersName) {
            List<Player> players = new List<Player>();

            for (int i = 0; i < 5; i++) {
                players.Add(new Player(playersName[i], Enum.Parse<RoleT>(comboBoxesT[i]), Enum.Parse<RoleCT>(comboBoxesCT[i])));
            }

            foreach (Player playerXML in players) {
                WritePlayerConfiguration(url, teamName, playerXML.Name, playerXML.RoleT.ToString(), playerXML.RoleCT.ToString());
            }

            Team team = new Team(teamName, players);
            return team;
        }

        private void WritePlayerConfiguration(string url, string teamName, string playerName, string roleT, string roleCT) {
            XDocument document = xmlManagement.GetFile(url);
            XElement element = xmlManagement.WriteSecondNode(document, teamName, "Player", "", url);
            xmlManagement.WriteChildNode(document, playerName, url, teamName, element, "Name");
            xmlManagement.WriteChildNode(document, roleT, url, teamName, element, "RoleT");
            xmlManagement.WriteChildNode(document, roleCT, url, teamName, element, "RoleCT");
        }
    }
}
