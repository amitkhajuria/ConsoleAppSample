using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharp_ConApp
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    }

    class JsonXML
    {
        static void MainJS(string[] args)
        {
            JsonXML obj = new JsonXML();

            obj.JSON2XML();


            obj.JSONSerilaize();
            //Searialize .Net Object to JSON

        }
        private  void JSON2XML()
        {
            string xml = @"<catalog>
                            <book id=""bk101"">" +
                               "<author>Gambardella, Matthew</author>" +
                               "<title>XML Developer's Guide</title>" +
                               "<genre>Computer</genre>" +
                               "<price>44.95</price>" +
                               "<publish_date>2000-10-01</publish_date>" +
                               "<description>An in-depth look at creating applications with XML.</description>" +
                           "</book>" +
                       "</catalog>";

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            var jsontext = JsonConvert.SerializeXmlNode(doc);
            Console.WriteLine(jsontext);

            Console.Write("*******************************");


            var xmlNode = JsonConvert.DeserializeXmlNode(jsontext).OuterXml;
            Console.WriteLine(xmlNode);

            Console.ReadKey();
        }

        private void JSONSerilaize()
        {
            // Serializaion  
            Employee empObj = new Employee();
            empObj.ID = 1;
            empObj.Name = "Manas";
            empObj.Address = "India";
            empObj.DOB = DateTime.Now;

            // Convert Employee object to JOSN string format   
            string jsonData = JsonConvert.SerializeObject(empObj);

            Console.Write("********JSON froom Object*************");
            Console.WriteLine(jsonData);

         }
        private void JSONDeserialize()
        {
            string json = @"{  
                    'ID': '1',  
                    'Name': 'Manas',  
                    'Address': 'India'  
                }";

            Employee empObj = JsonConvert.DeserializeObject<Employee>(json);
            Console.WriteLine(empObj.Name);

        }
    }
}
