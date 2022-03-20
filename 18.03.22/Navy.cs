using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._22
{
    [System.Xml.Serialization.XmlRoot("Navy")]
   public class Navy
    {
        [System.Xml.Serialization.XmlElement("ships")]
        public Ships Ships { get; set; }
        [System.Xml.Serialization.XmlElement("submarines")]
        public Submarines Submarines { get; set; }
        [System.Xml.Serialization.XmlElement("rockets")]
        public Rockets Rockets { get; set; }
    }
    public class Ships
    {
        [System.Xml.Serialization.XmlElement("ship")]
        public Ship[] ShipArray { get; set; }
    }
    public class Ship
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int sid { get; set; }
        [System.Xml.Serialization.XmlElement("damageLevel", Namespace = "")]
        public string sdamageLevel { get; set; }
        [System.Xml.Serialization.XmlElement("price", Namespace = "")]
        public int sprice { get; set; }
        [System.Xml.Serialization.XmlElement("loadcapacity", Namespace = "")]
        public int loadcapacity { get; set; }
    }
    public class Submarines
    {
        [System.Xml.Serialization.XmlElement("submarine")]
        public Submarine[] SubArray { get; set; }
    }
    public class Submarine
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int sbid { get; set; }
        [System.Xml.Serialization.XmlElement("damageLevel", Namespace = "")]
        public string sbdamageLevel { get; set; }
        [System.Xml.Serialization.XmlElement("price", Namespace = "")]
        public int sbprice { get; set; }
        [System.Xml.Serialization.XmlElement("depth", Namespace = "")]
        public int depth { get; set; }
    }
    public class Rockets
    {
        [System.Xml.Serialization.XmlElement("rocket")]
        public Rocket[] RocketrArray { get; set; }
    }
    public class Rocket
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int rid { get; set; }
        [System.Xml.Serialization.XmlElement("damageLevel", Namespace = "")]
        public string rdamageLevel { get; set; }
        [System.Xml.Serialization.XmlElement("price", Namespace = "")]
        public int rprice { get; set; }
        [System.Xml.Serialization.XmlElement("rangeofflight", Namespace = "")]
        public int rangeofflight { get; set; }
    }
}
