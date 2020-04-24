using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLGUI
{
    static class EnteringPoint
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XMLViewer());
            //doXml();
        }
        //static void doXml()
        //{
        //    //задаем путь к нашему рабочему файлу XML
        //    string fileName = "base.xml";
        //    //счетчик номера
        //    int trackId = 100;
        //    //Создание вложенными конструкторами.
        //    ///код дисциплины в учебном плане, наименование дисциплины, фамилия преподавателя, код группы, количество студентов в группе, 
        //    ///количество часов лекций, количество часов практики, наличие курсовой работы, вид итогового контроля (зачет или экзамен)
        //    ///


        //    XDocument doc = new XDocument(
        //        new XElement("library",
        //            new XElement("disc",
        //                new XAttribute("disc_id", trackId++),
        //                new XAttribute("disc_name", "Math"),
        //                new XAttribute("surname", "Blanch"),
        //                new XElement("gr_code", 100),
        //                new XElement("st_num", 18),
        //                new XElement("lect_num", 10),
        //                new XElement("hours_num", 12),
        //                new XElement("coursework", "кр"),
        //                new XElement("cu", "з")),
        //             new XElement("disc",
        //                new XAttribute("disc_id", trackId++),
        //                new XAttribute("disc_name", "Bio"),
        //                new XAttribute("surname", "Bronks"),
        //                new XElement("gr_code", 102),
        //                new XElement("st_num", 21),
        //                new XElement("lect_num", 15),
        //                new XElement("hours_num", 15),
        //                new XElement("coursework", "-"),
        //                new XElement("cu", "э")),
        //            new XElement("disc",
        //                new XAttribute("disc_id", trackId++),
        //                new XAttribute("disc_name", "English"),
        //                new XAttribute("surname", "White"),
        //                new XElement("gr_code", 104),
        //                new XElement("st_num", 18),
        //                new XElement("lect_num", 17),
        //                new XElement("hours_num", 18),
        //                new XElement("coursework", "кр"),
        //                new XElement("cu", "э")),
        //             new XElement("disc",
        //                new XAttribute("disc_id", trackId++),
        //                new XAttribute("disc_name", "Network"),
        //                new XAttribute("surname", "Brown"),
        //                new XElement("gr_code", 105),
        //                new XElement("st_num", 25),
        //                new XElement("lect_num", 12),
        //                new XElement("hours_num", 12),
        //                new XElement("coursework", "-"),
        //                new XElement("cu", "з"))));
        //    //сохраняем наш документ
        //    doc.Save(fileName);
        //}
    }
}
