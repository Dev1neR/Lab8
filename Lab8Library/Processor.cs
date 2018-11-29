using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Library
{
    public class Processor
    {
        private string family;
        public string Family
        {
            get { return family; }
            set
            {
                if (value.Length > 10)
                {
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
                    throw new InvalidSocketException();
                }
                else
                {
                    socket = value;
                }
            }
        }

        private double cores;
        public double Cores
        {
            get { return cores; }
            set
            {
                if (value > 16)
                {
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
                    throw new InvalidFreqException();
            }
        }

        public bool HasGraphics { get; set; }
        public bool HasMultiplier { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} | Socket: {2} | Ядер: {3} | Частота: {4} MHz| [{5}, {6}]\r\n",
                Family, Model, Socket,
                Cores, Freq,
                HasMultiplier ? "Є помножувач" : "Немає помножувача",
                HasGraphics ? "Є інтегрована карта" : "Немає інтегрованої карти"); ;
        }
    }
}
