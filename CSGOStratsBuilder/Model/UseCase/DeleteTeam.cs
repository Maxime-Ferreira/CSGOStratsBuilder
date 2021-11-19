using CSGOStratsBuilder.Model.XmlManagement;
using System.Xml.Linq;

namespace CSGOStratsBuilder.Model.UseCase {
    public class DeleteTeam {
        XMLManagement xmlManagement = XMLManagement.Instance;
        public void Execute(string url, string teamToDelete) {
            XDocument document = xmlManagement.GetFile(url);
            xmlManagement.DeleteElement(document, teamToDelete, url);
        }
    }
}
