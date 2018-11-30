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
        private BindingList<Processor> processors = new BindingList<Processor>();
        public fMain()
        {
            InitializeComponent();
            lbProcessorInfo.DataSource = processors;
            lbProcessorInfo.DisplayMember = "Model";
            lbProcessorInfo.ValueMember = "Family";


            lbProcessorInfo.SelectedIndexChanged += new EventHandler(lbProcessorInfo_SelectedIndexChanged);
        }

        private void btnAddProcessor_Click(object sender, EventArgs e)
        {
            Processor processor = new Processor();

            fProcessor fp = new fProcessor(processor);

            if (fp.ShowDialog() == DialogResult.OK)
            {
                processors.Add(processor);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lbProcessorInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string family = lbProcessorInfo.SelectedValue.ToString();

            Processor processor = (Processor)lbProcessorInfo.SelectedItem;
            MessageBox.Show("Процесор: " + family + " " +
                processor.Model + " | Ядер: " +
                processor.Cores + " | Тип роз'єму: " +
                processor.Socket + " | Частота: " +
                processor.Freq + "MHz | Помножувач: " +
                processor.HasMultiplier + " | Наявність відеокарти: " +
                processor.HasGraphics, "Інформація о процесорі");
        }
    }
}
