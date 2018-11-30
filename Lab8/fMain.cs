﻿using System;
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

            List<Processor> _processors = new List<Processor>
            {
                new Processor {Id = 1, Family = "i5", Model = "4790", Cores = 8, Socket = "1151", Freq = 3200, HasMultiplier = true, HasGraphics = false},
                new Processor {Id = 2, Family = "i7", Model = "4690", Cores = 4, Socket = "1151", Freq = 3600, HasMultiplier = true, HasGraphics = true},
            };

            lbProcessorInfo.DataSource = _processors;
            //lbProcessorInfo.DisplayMember = "Model";
            //lbProcessorInfo.ValueMember = "Id";
        }


        private void btnAddProcessor_Click(object sender, EventArgs e)
        {
            Processor processor = new Processor();

            fProcessor fp = new fProcessor(processor);

            if (fp.ShowDialog() == DialogResult.OK)
            {
                lbProcessorInfo.DataSource = null;
                lbProcessorInfo.Items.Add(processor.ToString());
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
