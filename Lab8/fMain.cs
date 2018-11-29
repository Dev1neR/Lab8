using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab8Library;

namespace Lab8
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddProcessor_Click(object sender, EventArgs e)
        {
            Processor processor = new Processor();

            fProcessor fp = new fProcessor(processor);

            if (fp.ShowDialog() == DialogResult.OK)
            {
                tbProcessorInfo.Text += processor.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
