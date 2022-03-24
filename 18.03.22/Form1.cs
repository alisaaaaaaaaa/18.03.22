using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _18._03._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGrid();
            
        }
        private void LoadGrid()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("navy.xml");
            XmlElement xroot = xDoc.DocumentElement;//корневой элемент
            foreach (XmlNode xnode in xroot)//проходимся по дочерним узлам:ships,submarines,rockets
            {
            //    if (xnode.Attributes.Count > 0)
            //    {
                    foreach (XmlNode xchildenode in xnode.ChildNodes)//проходимся по дочерним узлам предыдущего узла:ship,submarine,rocket
                    {
                        if (xchildenode.Name == "ship")
                        {
                        string damagelevel = "";
                        string price = "";
                        string loadcapacity ="";
                            foreach (XmlNode xchildechildenode in xchildenode.ChildNodes)//проходимся по полям каждого ship
                            {
                                if (xchildechildenode.Name == "damageLevel")
                                {
                                price = xchildechildenode.InnerText;
                                }
                                if (xchildechildenode.Name == "price")
                                {
                                     price = xchildechildenode.InnerText;
                                }
                                if (xchildechildenode.Name == "loadcapacity")
                                {
                                     loadcapacity = xchildechildenode.InnerText;
                                }
                            }
                        shiptable.Rows.Add(new object[] {loadcapacity, price, damagelevel });
                        }
                        if (xchildenode.Name.Equals("submarine"))
                        {
                        string damagelevel = "";
                        string price = "";
                        string depth = "";
                        foreach (XmlNode xchildechildenode in xchildenode.ChildNodes)//проходимся по полям каждого submarine
                        {
                            if (xchildechildenode.Name == "damageLevel")
                            {
                                price = xchildechildenode.InnerText;
                            }
                            if (xchildechildenode.Name == "price")
                            {
                                price = xchildechildenode.InnerText;
                            }
                            if (xchildechildenode.Name == "depth")
                            {
                                depth = xchildechildenode.InnerText;
                            }
                        }
                        }
                        if (xchildenode.Name.Equals("rocket"))
                        {
                        string damagelevel = "";
                        string price = "";
                        string rangeofflight = "";
                        foreach (XmlNode xchildechildenode in xchildenode.ChildNodes)//проходимся по полям каждого rocket
                            {
                            if (xchildechildenode.Name == "damageLevel")
                            {
                                price = xchildechildenode.InnerText;
                            }
                            if (xchildechildenode.Name == "price")
                            {
                                price = xchildechildenode.InnerText;
                            }
                            if (xchildechildenode.Name == "rangeofflight")
                            {
                                rangeofflight = xchildechildenode.InnerText;
                            }
                        }
                    }
                }
            }
        }
    }
}

