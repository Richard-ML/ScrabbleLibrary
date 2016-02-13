/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          IBag.cs                                                       *
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
    interface IBag: IRack
    {
        IRack NewRack();
    }
}
