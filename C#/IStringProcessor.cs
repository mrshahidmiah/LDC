using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDC
{
    public interface IStringProcessor
    {
        string Process(string inputString);

        IEnumerable<string> ProcessCollection(string[] stringCollection);
    }
}
