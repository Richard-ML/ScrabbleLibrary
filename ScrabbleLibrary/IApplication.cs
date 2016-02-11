using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleLibrary
{
    interface IApplication
    {
        bool CheckSpelling(string word);
    }
}
