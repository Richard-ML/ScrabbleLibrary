/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          IRack.cs                                                      *
 * Date:            Feb 11, 2016                                                  *
 * Author(s):       Richard Mills-Laursen & Craig MacLeod                         *
 * Student Number:  0639240 & #######                                             *
 * Description:     Represents a Scrabble rack.                                   *
 *                                                                                *
 **********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleLibrary
{
    public interface IRack
    {
        int GetPoints(string candidate);
        string PlayWord(string candidate);
        string SwapAll();
        string TopUp();
        string ToString();
    }
}
