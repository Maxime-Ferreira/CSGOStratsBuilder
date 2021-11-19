using CSGOStratsBuilder.Model.XmlManagement;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CSGOStratsBuilder.Model.UseCase {
    public class ReadTeamFile {
        XMLManagement xmlManagement = XMLManagement.Instance;
        public List<string> Execute() {
            string url = "..\\..\\Teams\\teams.xml";
            XDocument document = xmlManagement.GetFile(url);
            List<string> elements = xmlManagement.ReadFile(document);
            return elements;
        }
    }
}
