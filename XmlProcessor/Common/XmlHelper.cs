using System.Xml;

namespace XmlProcessor.Common
{
    /// <summary>
    /// Helper class for processing an XML document.
    /// </summary>
    public class XmlHelper
    {
        /// <summary>
        /// Loads the entire xml that corresponds to the template name provided.
        /// </summary>
        /// <param name="templateName">Template Name</param>
        /// <returns>Xml Document</returns>
        public XmlDocument LoadXmlDocument(string templateName)
        {
            XmlDocument xmlDocument = new();
            xmlDocument.Load(Path.Combine(Directory.GetCurrentDirectory(), templateName));
            return xmlDocument;
        }
    }
}
