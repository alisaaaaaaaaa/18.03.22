using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace _18._03._22
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            XmlDocument xml = new XmlDocument();
            xml.Load("navy.xml");
            XmlElement root = xml.DocumentElement;//корневой элемент
            List<string> DL = new List<string>();
            List<string> price = new List<string>();
            List<string> LC = new List<string>();
            List<string> DL1 = new List<string>();
            List<string> price1 = new List<string>();
            List<string> depth = new List<string>();
            List<string> DL2 = new List<string>();
            List<string> price2 = new List<string>();
            List<string> RF = new List<string>();
            foreach (XmlNode node in root)//проходимся по дочерним узлам:ships,submarines,rockets
            {
                if (node.Attributes.Count > 0)
                {
                    foreach (XmlNode childenode in node.ChildNodes)//проходимся по дочерним узлам предыдущего узла:ship,submarine,rocket
                    {
                        if (childenode.Name.Equals("ship"))
                        {
                            foreach (XmlNode childechildenode in childenode.ChildNodes)//проходимся по полям каждого ship
                            {
                                if (childechildenode.Name.Equals("damagelevel"))
                                {
                                    DL.Add(childechildenode.InnerText);

                                }
                                if (childechildenode.Name.Equals("price"))
                                {
                                    price.Add(childechildenode.InnerText);
                                }
                                if (childechildenode.Name.Equals("loadcapacity"))
                                {
                                    LC.Add(childechildenode.InnerText);
                                }
                            }
                        }
                        if (childenode.Name.Equals("submarine"))
                        {
                            foreach (XmlNode childechildenode in childenode.ChildNodes)//проходимся по полям каждого submarine
                            {
                                if (childechildenode.Name.Equals("damagelevel"))
                                {
                                    DL1.Add(childechildenode.InnerText);
                                }
                                if (childechildenode.Name.Equals("price"))
                                {
                                    price1.Add(childechildenode.InnerText);
                                }
                                if (childechildenode.Name.Equals("depth"))
                                {
                                    depth.Add(childechildenode.InnerText);
                                }
                            }
                        }
                        if (childenode.Name.Equals("rocket"))
                        {
                            foreach (XmlNode childechildenode in childenode.ChildNodes)//проходимся по полям каждого rocket
                            {
                                if (childechildenode.Name.Equals("damagelevel"))
                                {
                                    DL2.Add(childechildenode.InnerText);
                                }
                                if (childechildenode.Name.Equals("price"))
                                {
                                    price2.Add(childechildenode.InnerText);
                                }
                                if (childechildenode.Name.Equals("rangeofflight"))
                                {
                                    RF.Add(childechildenode.InnerText);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
