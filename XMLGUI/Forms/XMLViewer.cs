using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XMLGUI.Forms;
using XMLGUI.EventsLib;
using System.Xml.Linq;

namespace XMLGUI
{
    public partial class XMLViewer : Form
    {
        //задаем путь к нашему рабочему файлу XML
        public IEnumerable<XElement> tracks;
        public static XDocument doc = XDocument.Load("base.xml");
        public XMLViewer()
        {
            InitializeComponent();
        }
        private void OnSetFilterClick(object sender, EventArgs e)
        {
            FilterProperties setFilterForm = new FilterProperties();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChangeEvent);
            setFilterForm.Show();
        }


        public void OnFilterChangeEvent(object sender, FilterChangeEventArgs e)
        {
            tracks = from t in doc.Root.Elements("disc")
                     orderby t.Attribute("disc_id").Value
                     select t;

            if (e.Name == "btn_surname")
            {
                tracks = doc.Root.Descendants("disc").Where(
                t => t.Attribute("surname").Value == e.Param).ToList();
                WriteText(tracks);
            }

            if (e.Name == "btn_gr_code")
            {
                tracks = doc.Root.Descendants("disc").Where(
                t => t.Element("gr_code").Value == e.Param).ToList();
                WriteText(tracks);
            }

            if (e.Name == "btn_coursework")
            {
                tracks = doc.Root.Descendants("disc").Where(
                   t => t.Element("coursework").Value == e.Param).ToList();
                WriteText(tracks);
            }
            if (e.Name == "btn_cu")
            {
                tracks = doc.Root.Descendants("disc").Where(
                   t => t.Element("cu").Value == e.Param).ToList();
                WriteText(tracks);
            }
        }
        private void XMLViewer_Load(object sender, EventArgs e)
        {
            tracks = from t in doc.Root.Elements("disc")
                     select t;
            WriteText(tracks);

        }
        public IEnumerable<XElement> WriteText(IEnumerable<XElement> lib)
        {

            tableView.Text = "";
            foreach (XElement el in lib)
            {
                tableView.Text += "";
                //Выводим имя элемента и значение аттрибута  
                tableView.Text += el.Name + " ";
                tableView.Text += el.Attribute("disc_id").Value + Environment.NewLine;
                //tableView.Text += el.Attribute("id").Value;
                tableView.Text += "  Attributes:" + Environment.NewLine;
                //выводим в цикле все аттрибуты, заодно смотрим как они себя преобразуют в строку
                foreach (XAttribute attr in el.Attributes())
                {
                    tableView.Text += "     " + attr + Environment.NewLine;
                }
                tableView.AppendText("  Elements:");
                tableView.Text += Environment.NewLine;
                //выводим в цикле названия всех дочерних элементов и их значения
                foreach (XElement element in el.Elements())
                    tableView.Text += "      " + element.Name + ":" + element.Value + Environment.NewLine;
            }
            return lib;
        }
       
        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete newDeleteItems = new Delete();
            newDeleteItems.DeleteChangeEvent += new EventHandler<DeleteChangeEventArgs>(this.OnDeleteChangeEvent);
            newDeleteItems.Show();
        }

        private void FilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc.Save("base.xml");
            DialogResult result = MessageBox.Show("Сохранено");
        }
        int code = 300;
        
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert newInsertedElems = new Insert();
            //newInsertedElems.DeleteChangeEvent += new EventHandler<DeleteChangeEventArgs>(this.OnDeleteChangeEvent);
            newInsertedElems.Show();
            newInsertedElems.label11.Text = Convert.ToString(code);
            code++;

            tracks = from t in doc.Descendants("disc")
                     select t;
            WriteText(tracks);
        }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracks = from t in doc.Descendants("disc")
                         //orderby t.Attribute("disc_id").Value
                     select t;
            WriteText(tracks);
        }
        public void OnDeleteChangeEvent(object sender, DeleteChangeEventArgs e)
        {


            if (e.Name == "btn_disc_id")
            {
                doc.Descendants("disc").Where(em => em.Attribute("disc_id").Value == e.Param).Remove();
                Console.WriteLine(doc);

            }

            if (e.Name == "btn_disc_name")
            {
                doc.Descendants("disc").Where(em => em.Attribute("disc_name").Value == e.Param).Remove();
                Console.WriteLine(doc);

            }
            tracks = from t in doc.Descendants("disc")
                     select t;

            WriteText(tracks);

        }

        public IEnumerable<XElement> Filter(IEnumerable<XElement> tracks, string v)
        {
            throw new NotImplementedException();
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracks = from t in doc.Descendants("disc")
                     select t;
            WriteText(tracks);
        }
    }
}
