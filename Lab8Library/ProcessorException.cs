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

    public class InvalidFamilyException : Exception
    {
        public InvalidFamilyException() : base("Неправильне сімейство процесора.") { }
    }

    public class InvalidModelException : ProcessorException
    {
        public InvalidModelException() : base("Неправильна модель процесора.") { }
    }

    public class InvalidFreqException : ProcessorException
    {
        public InvalidFreqException() : base("Неправильна внутрішня частота.") { }
    }

    public class InvalidSocketException : ProcessorException
    {
        public InvalidSocketException() : base("Неправильний тип роз'єму.") { }
    }

    public class InvalidCoresException : ProcessorException
    {
        public InvalidCoresException() : base("Неправильна кількість ядер.") { }
    }
}
