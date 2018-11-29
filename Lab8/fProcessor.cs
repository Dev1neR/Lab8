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
    public partial class fProcessor : Form
    {
        private Processor TheProcessor;
        internal fProcessor(Processor t)
        {
            TheProcessor = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheProcessor.Family = tbFamily.Text.Trim();
            TheProcessor.Model = tbModel.Text.Trim();
            TheProcessor.Socket = tbSocket.Text.Trim();
            TheProcessor.Cores = int.Parse(tbCores.Text.Trim());
            TheProcessor.Freq = int.Parse(tbFreq.Text.Trim());
            TheProcessor.HasMultiplier = chbHasMultiplier.Checked;
            TheProcessor.HasGraphics = chbHasGraphics.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fProcessor_Load(object sender, EventArgs e)
        {
            if (TheProcessor != null)
            {
                tbFamily.Text = TheProcessor.Family;
                tbModel.Text = TheProcessor.Model;
                tbSocket.Text = TheProcessor.Socket;
                tbCores.Text = TheProcessor.Cores.ToString("");
                tbFreq.Text = TheProcessor.Freq.ToString("");
                chbHasMultiplier.Checked = TheProcessor.HasMultiplier;
                chbHasGraphics.Checked = TheProcessor.HasGraphics;
            }
        }

        private void tbCores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void tbFreq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                MessageBox.Show("Заборонено використання літер та десяткових чисел.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
