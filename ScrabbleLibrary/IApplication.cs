/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          IApplication.cs                                               *
 * Date:            Feb 11, 2016                                                  *
 * Author(s):       Richard Mills-Laursen & Craig MacLeod                         *
 * Student Number:  0639240 & #######                                             *
 * Description:     Represents a Scrabble bag.                                    *
 *                                                                                *
 **********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleLibrary
{
    /*
This interface is obtained by constructing an object of type Microsoft.Office.Interop.Word.Application.
The CheckSpelling() method also has several optional parameters but only an argument for the word parameter must be provided when calling it. Note that only words in lowercase format will be properly spellchecked.
    */
    interface IApplication
    {
        bool CheckSpelling(string word);
    }
}
