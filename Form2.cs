using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнотец
{
    public partial class MsBoxForm : Form
    {
        public string msg1;
        public MsBoxForm()
        {
            InitializeComponent();
        }

        private void MsBoxForm_Load(object sender, EventArgs e)
        {
            Msg.Text = msg1;
        }

        public void ChangeMessage(string content)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
