using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Library
{
    class ProcessorException : Exception
    {
        public ProcessorException(string message) : base(message) { }
    }

    class InvalidFamilyException : ProcessorException
    {
        public InvalidFamilyException() : base("Type correct family") { }
    }

    class InvalidModelException : ProcessorException
    {
        public InvalidModelException() : base("Invalid model") { }
    }

    class InvalidFreqException : ProcessorException
    {
        public InvalidFreqException() : base("Processor with this frequency does not exist") { }
    }

    class InvalidSocketException : ProcessorException
    {
        public InvalidSocketException() : base("Invalid Socket") { }
    }

    class InvalidCoresException : ProcessorException
    {
        public InvalidCoresException() : base("Invalid number of cores") { }
    }
}
