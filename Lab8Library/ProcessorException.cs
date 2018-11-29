using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Library
{
    public class ProcessorException : Exception
    {
        public ProcessorException(string message) : base(message) { }
    }

    public class InvalidFamilyException : ProcessorException
    {
        public InvalidFamilyException() : base("Type correct family") { }
    }

    public class InvalidModelException : ProcessorException
    {
        public InvalidModelException() : base("Invalid model") { }
    }

    public class InvalidFreqException : ProcessorException
    {
        public InvalidFreqException() : base("Processor with this frequency does not exist") { }
    }

    public class InvalidSocketException : ProcessorException
    {
        public InvalidSocketException() : base("Invalid Socket") { }
    }

    public class InvalidCoresException : ProcessorException
    {
        public InvalidCoresException() : base("Invalid number of cores") { }
    }
}
