using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V8
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            FormYes formyes = new FormYes();
            formyes.ShowDialog();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            FormNo formno = new FormNo();
            formno.ShowDialog();
        }
    }
}
