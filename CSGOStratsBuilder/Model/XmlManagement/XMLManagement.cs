using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace CSGOStratsBuilder.Model.XmlManagement {
    public class XMLManagement {
        private XMLManagement() {
                
        }

        private static XMLManagement instance = null;
        public static XMLManagement Instance {
            get {
                if (instance == null) {
                    instance = new XMLManagement();
                }
                return instance;
            }
        }

        public XDocument CreateFile(string uri, string rootNode) {
            XDocument xmlDocument = new XDocument(new XElement(rootNode));
            xmlDocument.Save(uri);
            return xmlDocument;
        }

        public void WriteChildNode(XDocument xmlDocument, string input, string uri, string firstNode, XElement playerElement, string childNode) {
            XElement element = playerElement;
            element.Add(new XElement(childNode, input));
            xmlDocument.Save(uri);
        }

        public XElement WriteSecondNode(XDocument document, string firstNode, string nodeName, string input, string url) {
            XElement element = new XElement(nodeName, input);
            document.Element(firstNode).Add(element);
            document.Save(url);
            return element;
        }

        public XDocument GetFile(string uri) {
            XDocument xmlDocument = XDocument.Load(uri);
            return xmlDocument;
        }

        public List<string> ReadFile(XDocument document) {
            List<string> elements = document.Descendants("Teams").Descendants("Team").Select(t => t.Value).ToList();
            return elements;
        }

        public void DeleteElement(XDocument document, string nodeToDelete, string url) {
            document.Descendants("Teams").Descendants("Team").Where(e => e.Value == nodeToDelete).ToList().ForEach(e => e.Remove());
            document.Save(url);
        }
    }
}
