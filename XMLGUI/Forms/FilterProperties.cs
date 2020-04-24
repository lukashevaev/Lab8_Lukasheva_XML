using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLGUI.EventsLib;

namespace XMLGUI.Forms
{
    public partial class FilterProperties : Form
    {
        public event EventHandler<FilterChangeEventArgs> FilterChangeEvent;
        public FilterProperties()
        {
            InitializeComponent();
        }
        private void btn_cu_Click(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.paramTxtBox.Text, this.btn_cu.Name));
            this.Close();
        }
        private void btn_coursework_Click(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.paramTxtBox.Text, this.btn_coursework.Name));
            this.Close();
        }
        
        private void btn_surname_Click(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.paramTxtBox.Text, this.btn_surname.Name));
            this.Close();
        }
        private void Btn_gr_code_Click_1(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            handler?.Invoke(this, new FilterChangeEventArgs(this.paramTxtBox.Text, this.btn_gr_code.Name));
            this.Close();
        }
    }
}
