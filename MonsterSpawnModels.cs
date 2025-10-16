using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace MonasterSetBase
{
    [XmlRoot("MonsterSpawn")]
    public class MonsterSpawnDocument
    {
        public MonsterSpawnDocument()
        {
            this.Maps = new List<MonsterMap>();
        }

        [XmlElement("Map")]
        public List<MonsterMap> Maps { get; set; }
    }

    public class MonsterMap
    {
        public MonsterMap()
        {
            this.Name = string.Empty;
            this.Spots = new List<MonsterSpot>();
            this.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        [XmlAttribute("Number")]
        public int Number { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("Spot")]
        public List<MonsterSpot> Spots { get; set; }

        [XmlIgnore]
        public Dictionary<string, string> ExtraAttributes { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] ExtraSerializedAttributes
        {
            get
            {
                if (this.ExtraAttributes == null || this.ExtraAttributes.Count == 0)
                    return (XmlAttribute[]) null;
                XmlDocument xmlDocument = new XmlDocument();
                List<XmlAttribute> xmlAttributeList = new List<XmlAttribute>();
                foreach (KeyValuePair<string, string> extraAttribute in this.ExtraAttributes)
                {
                    XmlAttribute attribute = xmlDocument.CreateAttribute(extraAttribute.Key);
                    attribute.Value = extraAttribute.Value;
                    xmlAttributeList.Add(attribute);
                }
                return xmlAttributeList.ToArray();
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    this.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    return;
                }
                Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (XmlAttribute xmlAttribute in value)
                {
                    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Name) && !dictionary.ContainsKey(xmlAttribute.Name))
                        dictionary.Add(xmlAttribute.Name, xmlAttribute.Value);
                }
                this.ExtraAttributes = dictionary;
            }
        }
    }

    public class MonsterSpot
    {
        public MonsterSpot()
        {
            this.Description = string.Empty;
            this.Spawns = new List<MonsterSpawnEntry>();
            this.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        [XmlAttribute("Type")]
        public int Type { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlElement("Spawn")]
        public List<MonsterSpawnEntry> Spawns { get; set; }

        [XmlIgnore]
        public Dictionary<string, string> ExtraAttributes { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] ExtraSerializedAttributes
        {
            get
            {
                if (this.ExtraAttributes == null || this.ExtraAttributes.Count == 0)
                    return (XmlAttribute[]) null;
                XmlDocument xmlDocument = new XmlDocument();
                List<XmlAttribute> xmlAttributeList = new List<XmlAttribute>();
                foreach (KeyValuePair<string, string> extraAttribute in this.ExtraAttributes)
                {
                    XmlAttribute attribute = xmlDocument.CreateAttribute(extraAttribute.Key);
                    attribute.Value = extraAttribute.Value;
                    xmlAttributeList.Add(attribute);
                }
                return xmlAttributeList.ToArray();
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    this.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    return;
                }
                Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (XmlAttribute xmlAttribute in value)
                {
                    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Name) && !dictionary.ContainsKey(xmlAttribute.Name))
                        dictionary.Add(xmlAttribute.Name, xmlAttribute.Value);
                }
                this.ExtraAttributes = dictionary;
            }
        }
    }

    public class MonsterSpawnEntry
    {
        public MonsterSpawnEntry()
        {
            this.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        [XmlAttribute("Index")]
        public int Index { get; set; }

        [XmlAttribute("Distance")]
        public int Distance { get; set; }

        [XmlAttribute("StartX")]
        public int StartX { get; set; }

        [XmlAttribute("StartY")]
        public int StartY { get; set; }

        [XmlAttribute("Dir")]
        public int Direction { get; set; }

        [XmlAttribute("EndX")]
        public int? EndX { get; set; }

        [XmlAttribute("EndY")]
        public int? EndY { get; set; }

        [XmlAttribute("Count")]
        public int? Count { get; set; }

        [XmlAttribute("Element")]
        public int? Element { get; set; }

        [XmlIgnore]
        public Dictionary<string, string> ExtraAttributes { get; set; }

        [XmlAnyAttribute]
        public XmlAttribute[] ExtraSerializedAttributes
        {
            get
            {
                if (this.ExtraAttributes == null || this.ExtraAttributes.Count == 0)
                    return (XmlAttribute[]) null;
                XmlDocument xmlDocument = new XmlDocument();
                List<XmlAttribute> xmlAttributeList = new List<XmlAttribute>();
                foreach (KeyValuePair<string, string> extraAttribute in this.ExtraAttributes)
                {
                    XmlAttribute attribute = xmlDocument.CreateAttribute(extraAttribute.Key);
                    attribute.Value = extraAttribute.Value;
                    xmlAttributeList.Add(attribute);
                }
                return xmlAttributeList.ToArray();
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    this.ExtraAttributes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    return;
                }
                Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (XmlAttribute xmlAttribute in value)
                {
                    if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Name) && !dictionary.ContainsKey(xmlAttribute.Name))
                        dictionary.Add(xmlAttribute.Name, xmlAttribute.Value);
                }
                this.ExtraAttributes = dictionary;
            }
        }
    }

    [XmlRoot("MonsterList")]
    public class MonsterDefinitionList
    {
        public MonsterDefinitionList()
        {
            this.Monsters = new List<MonsterDefinition>();
        }

        [XmlElement("Monster")]
        public List<MonsterDefinition> Monsters { get; set; }
    }

    public class MonsterDefinition
    {
        public MonsterDefinition()
        {
            this.Name = string.Empty;
        }

        [XmlAttribute("Index")]
        public int Index { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
