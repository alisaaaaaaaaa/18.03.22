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
        public static Navy Load(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("Нет доступа к файлу {0}", path);
                return null;
            }
            else
            {
                Console.WriteLine("Loading...");
            }
            try
            {
                MemoryStream rewData = new MemoryStream(File.ReadAllBytes(path));
                XmlSerializer xmls = new XmlSerializer(typeof(Navy));
                var XmlList = (Navy)xmls.Deserialize(rewData);
                Console.WriteLine("xml обратан");
                return XmlList;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка обработки данных xml");
                return null;
            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string path = "navy.xml";
            var result = Load(path);

        }
    }
}
