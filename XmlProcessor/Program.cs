// See https://aka.ms/new-console-template for more information
using System.Xml;
using XmlProcessor.Common;

Console.WriteLine("Hello, let's read the XML!");

try
{
    XmlHelper xmlHelper = new();
    XmlDocument employeeXml = xmlHelper.LoadXmlDocument("EmployeeData.xml");

    XmlNodeList? nodeList = employeeXml.DocumentElement!.SelectNodes("employee");
    if (nodeList != null)
    {
        foreach (XmlNode node in nodeList)
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"ID: {node.Attributes!.GetNamedItem("id")!.Value}");
            Console.WriteLine($"Name: {node.SelectSingleNode("name")!.InnerText}");
            Console.WriteLine($"Email: {node.SelectSingleNode("email")!.InnerText}");
            Console.WriteLine($"Contact Number: {node.SelectSingleNode("contact_number")!.InnerText}");

            XmlNode? addressNode = node.SelectSingleNode("address");
            if (addressNode != null)
            {
                Console.WriteLine($"Address City: {addressNode.SelectSingleNode("city")!.InnerText}");
                Console.WriteLine($"Address Country: {addressNode.SelectSingleNode("country")!.InnerText}");
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex}");
}