using System.Collections.Generic;
using System.Linq;
using System.Xml;


namespace userManagment
{
    class Xml
    {

        public List<string> readXML(string Element)
        {

            string str = null;
            List<string> childnodes = new List<string>();                                                       //In deze list komen alle resultaten die in het xmlbestand aanwezig zijn binnen het bijhorende 'element' waarbinnen gezocht wordt.

            XmlDataDocument xmldoc = new XmlDataDocument();                                                     //We maken een nieuwe XmlDataDocument class aan.
            XmlNodeList xmlnode;

            //FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load("http://worldcraft.eu/vpnclient/servers.xml");
            xmlnode = xmldoc.GetElementsByTagName(Element);                                                     //Hier geven we een string op met de naam van het 'element'. Ook wel gewoon een sectie in de xml file. Bijvoorbeeld "<Servers> </servers>" in dit geval.


            for (int i = 0; i < xmlnode[0].ChildNodes.Count; i++)
            {

                str = xmlnode[0].ChildNodes.Item(i).InnerText.Trim();                                           //We lezen alle childnodes van de config uit.
                childnodes.Add(str);                                                                            //Hier voegen we alle childnodes aan de list toe.
            }

            return childnodes;

        }

    }
}
