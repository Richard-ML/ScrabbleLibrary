/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          Bag.cs                                                        *
 * Date:            Feb 11, 2016                                                  *
 * Author(s):       Richard Mills-Laursen & Craig MacLeod                         *
 * Student Number(s):  0639240 & #######                                          *
 * Description:     Implementation class for the Scrabble bag interface.          *
 *                                                                                *
 * Modifications:   Feb 11, 2016                                                  *
 *                  This is an example modification description.                  *
 *                                                                                *
 *                  Feb 11, 2016                                                  *
 *                  This is another modification description example.             *
 **********************************************************************************/
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
