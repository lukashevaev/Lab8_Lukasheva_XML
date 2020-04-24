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
    public partial class Delete : Form
    {

        public event EventHandler<DeleteChangeEventArgs> DeleteChangeEvent;
        public Delete()
        {
            InitializeComponent();
        }
        private void Btn_disc_name_Click(object sender, EventArgs e)
        {
            EventHandler<DeleteChangeEventArgs> handler = DeleteChangeEvent;
            handler?.Invoke(this, new DeleteChangeEventArgs(this.paramTxtBox.Text, this.btn_disc_name.Name));
            this.Close();
        }

        private void Btn_disc_id_Click(object sender, EventArgs e)
        {
            EventHandler<DeleteChangeEventArgs> handler = DeleteChangeEvent;
            handler?.Invoke(this, new DeleteChangeEventArgs(this.paramTxtBox.Text, this.btn_disc_id.Name));
            this.Close();
        }

      

    }

}
