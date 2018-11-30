using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8Library
{
    public class Processor
    {
        public int Id { get; set; }
        private string family;
        //public string Family
        //{
        //    get { return family; }
        //    set
        //    {
        //        if (!value.Equals("i3") &&
        //            !value.Equals("i5") &&
        //            !value.Equals("i7") &&
        //            !value.Equals("Pentium") &&
        //            !value.Equals("Athlon") &&
        //            !value.Equals("FX") &&
        //            !value.Equals("Ryzen"))
        //        {
        //            MessageBox.Show("Неправильне сімейство процесора.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            family = value;
        //        }
        //    }
        //}
        public string Family
        {
            get { return family; }
            set
            {
                if (!value.Equals("i3") &&
                    !value.Equals("i5") &&
                    !value.Equals("i7") &&
                    !value.Equals("Pentium") &&
                    !value.Equals("Athlon") &&
                    !value.Equals("FX") &&
                    !value.Equals("Ryzen"))
                {
                    MessageBox.Show("Неправильне сімейство процесора.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidFamilyException();
                }
                else
                {
                    family = value;
                }
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length > 5)
                {
                    MessageBox.Show("Неправильна модель процесора.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidModelException();
                }
                else
                {
                    model = value;
                }
            }
        }

        private string socket;
        public string Socket
        {
            get { return socket; }
            set
            {
                if (value.Length > 6)
                {
                    MessageBox.Show("Неправильний тип роз'єму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidSocketException();
                }
                else
                {
                    socket = value;
                }
            }
        }

        private int cores;
        public int Cores
        {
            get { return cores; }
            set
            {
                if (value > 16)
                {
                    MessageBox.Show("Неправильна кількість ядер.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidCoresException();
                }
                else
                {
                    cores = value;
                }
            }
        }

        private int freq;
        public int Freq
        {
            get { return freq; }
            set
            {
                if (value > 0 && value < 5000)
                {
                    freq = value;
                }
                else
                {
                    MessageBox.Show("Неправильна внутрішня частота.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new InvalidFreqException();
                }
            }
        }

        public bool HasGraphics { get; set; }
        public bool HasMultiplier { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} | Socket: {2} | Ядер: {3} | Частота: {4} MHz | [{5}, {6}]\r\n",
                Family, Model, Socket,
                Cores, Freq,
                HasMultiplier ? "Є помножувач" : "Немає помножувача",
                HasGraphics ? "Є інтегрована карта" : "Немає інтегрованої карти"); ;
        }
    }
}
