using CSGOStratsBuilder.Model.XmlManagement;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace CSGOStratsBuilder.Model.UseCase {
    public class ReadTeamFile {
        XMLManagement xmlManagement = XMLManagement.Instance;
        public List<string> Execute() {
            string url = "..\\..\\Teams\\teams.xml";
            List<string> elements = new List<string>();
            if (File.Exists(url)) {
                XDocument document = xmlManagement.GetFile(url);
                elements = xmlManagement.ReadFile(document);
            }
            return elements;
        }
    }
}
