using CSGOStratsBuilder.Model.XmlManagement;
using System.IO;
using System.Xml.Linq;

namespace CSGOStratsBuilder.Model.UseCase {
    public class CreateTeamFile {
        private readonly XMLManagement xmlManagement = XMLManagement.Instance;
        public void Execute(string name) {
            string url = "..\\..\\Teams\\teams.xml";
            string mainNode = "Teams";
            string childNode = "Team";
            XDocument xmlDocument;
            if (!File.Exists(url)) {
                xmlDocument = xmlManagement.CreateFile(url, "Teams");
            }
            else {
                xmlDocument = xmlManagement.GetFile(url);
            }
            xmlManagement.WriteSecondNode(xmlDocument, mainNode, childNode, name, url);
        }
    }
}
