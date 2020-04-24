using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLGUI.Forms
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;

            if ((txt_disc_name.Text == "") | (txt_surname.Text == "") | (txt_gr_code.Text == "") |
                (txt_st_num.Text == "") | (txt_lect_num.Text == "") | (txt_hours_num.Text == "")
                | (txt_coursework.Text == "") | (txt_cu.Text == ""))
            {
                DialogResult result = MessageBox.Show("Не полностью заполнена информация!", "Error", buttons, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Close();
                }
            }
            else
            {
                InsertEl(XMLViewer.doc, label11.Text, txt_disc_name.Text, txt_surname.Text, txt_gr_code.Text, txt_st_num.Text, txt_lect_num.Text, txt_hours_num.Text, txt_coursework.Text,txt_cu.Text);
                Close();
                
            }
        }
        public void InsertEl(XDocument doc, string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v)
            {
                XMLViewer.doc.Element("library").Add(
           new XElement("disc",
                       new XAttribute("disc_id", v1),
                       new XAttribute("disc_name", v2),
                       new XAttribute("surname", v3),
                       new XElement("gr_code", v4),
                       new XElement("st_num", v5),
                       new XElement("lect_num", v6),
                       new XElement("hours_num", v7),
                       new XElement("coursework", v8),
                       new XElement("cu", v)
                       //,new XElement("cu_num", vv)
                       ));

                Console.WriteLine(XMLViewer.doc);
            }

           
            //XMLViewer.doc.Save("base.xml"); 
         

        

        

        private void Txt_disc_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_gr_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_st_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_lect_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_cu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_coursework_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_hours_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_disc_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public void Label1_Click(object sender, EventArgs e)
        {

        }

        public void InsertEl(XDocument doc, string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8)
        {
            throw new NotImplementedException();
        }
    }
}
