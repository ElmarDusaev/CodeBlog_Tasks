using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace Task182.Model
{
    [Serializable]
    [XmlRoot(ElementName = "Valute")]
        public class Valute
        {
            [XmlElement(ElementName = "NumCode")]
            public string NumCode { get; set; }
            [XmlElement(ElementName = "CharCode")]
            public string CharCode { get; set; }
            [XmlElement(ElementName = "Nominal")]
            public int Nominal { get; set; }
            [XmlElement(ElementName = "Name")]
            public string Name { get; set; }
            [XmlElement(ElementName = "Value")]
            public string Value { get; set; }
            [XmlAttribute(AttributeName = "ID")]
            public string ID { get; set; }
            public string FullName { get { return "(" + CharCode + ") " + Name; } }
    }

    [Serializable]
    [XmlRoot(ElementName = "ValCurs")]
        public class ValCurs
        {
            [XmlElement(ElementName = "Valute")]
            public List<Valute> Valute { get; set; }
            [XmlAttribute(AttributeName = "Date")]
            public string Date { get; set; }
            [XmlAttribute(AttributeName = "name")]
            public string Name { get; set; }
        }

}
