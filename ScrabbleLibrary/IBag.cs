﻿/*
 * Program:         ScrabbleLibrary.dll
 * Module:          IBag.cs
 * Date:            Feb 11, 2016
 * Author:          Richard Mills-Laursen
 * Student Number:  0639240
 * Description:     Represents a Scrabble bag.
 *
 * Modifications:   Feb 11, 2016 
 *                  This is an example modification description.
 *  
 *                  Feb 11, 2016
 *                  This is another modification description example.
 */
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