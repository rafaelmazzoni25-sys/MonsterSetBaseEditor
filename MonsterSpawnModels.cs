using System.Collections.Generic;
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
        }

        [XmlAttribute("Number")]
        public int Number { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("Spot")]
        public List<MonsterSpot> Spots { get; set; }
    }

    public class MonsterSpot
    {
        public MonsterSpot()
        {
            this.Description = string.Empty;
            this.Spawns = new List<MonsterSpawnEntry>();
        }

        [XmlAttribute("Type")]
        public int Type { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlElement("Spawn")]
        public List<MonsterSpawnEntry> Spawns { get; set; }
    }

    public class MonsterSpawnEntry
    {
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
