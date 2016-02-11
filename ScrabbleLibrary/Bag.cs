using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleLibrary
{
    class Bag : IBag
    {
        Bag() { }

        public int GetPoints(string candidate)
        {
            throw new NotImplementedException();
        }

        public string PlayWord(string candidate)
        {
            throw new NotImplementedException();
        }

        public string SwapAll()
        {
            throw new NotImplementedException();
        }

        public string TopUp()
        {
            throw new NotImplementedException();
        }

        IRack IBag.NewRack()
        {
            throw new NotImplementedException();
        }

        IRack NewRack() {
            IRack rack = null;
            
            return rack; }




    }
}
