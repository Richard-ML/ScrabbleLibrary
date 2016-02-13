/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          Bag.cs                                                        *
 * Date:            Feb 11, 2016                                                  *
 * Author(s):       Richard Mills-Laursen & Craig MacLeod                         *
 * Student Number(s):  0639240 & #######                                          *
 * Description:     Implementation class for the Scrabble bag interface.          *
 *                                                                                *
 **********************************************************************************/
 //Hello
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*ScrabbleLibrary
  Must be implemented as a class library assembly using C#
  Must work with your own .NET client
  Must work fully with the Excel client provided (ScrabbleExcelClient.xlsm) without making any changes to the client except to add a reference to your own
   ScrabbleLibrary assembly’s type library (a type library for your ScrabbleLibrary will be generated and registered automatically if you configure the project properties required to use it via COM Interop).
  Must recognize letters in UPPERCASE format. May optionally recognize lowercase letters as well

    */
namespace ScrabbleLibrary
{
    class Bag : IBag
    {

        private Dictionary<char, int> letterValue = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };
        private List<char> letters;

        Bag() {
           List<char> temp = new List<char>
            {
                'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A',
                'B', 'B',
                'C', 'C',
                'D', 'D', 'D', 'D',
                'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E',
                'F', 'F',
                'G', 'G', 'G',
                'H', 'H',
                'I', 'I', 'I', 'I', 'I', 'I', 'I', 'I', 'I',
                'J',
                'K',
                'L', 'L', 'L', 'L',
                'M', 'M',
                'N', 'N', 'N', 'N', 'N', 'N',
                'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O',
                'P', 'P',
                'Q',
                'R', 'R', 'R', 'R', 'R', 'R',
                'S', 'S', 'S', 'S',
                'T', 'T', 'T', 'T', 'T', 'T',
                'U', 'U', 'U', 'U',
                'V', 'V',
                'W', 'W',
                'X',
                'Y', 'Y',
                'Z'
            };

            //shuffle chars into letters list
            Random rNum = new Random();
            int randNum;
            while (temp.Count > 0)
            {
                randNum = rNum.Next(0, temp.Count);
                letters.Add(temp[randNum]); 
                temp.RemoveAt(randNum); 
            }


 
        }



/* GetPoints() method accepts a string containing a candidate word and returns its potential point value based on two criteria: 1)
the letters of the candidate string are a subset of the letters in the current rack object, 2) the candidate provided is a valid
word as tested using the IApplication interface’s CheckSpelling() method. If a candidate word fails to meet either criteria
the method return 0.*/
        public int GetPoints(string candidate)
        {
            int score = 0;
            candidate = candidate.ToLower();
            int value;
            
            for (int nc = 0; nc < candidate.Length; nc++)
            {
                if (letterValue.TryGetValue(candidate.ElementAt(nc), out value))
                     score += value;                
            }
            return score;
        }


/*PlayWord() method tests the candidate word just as GetPoints() does, but for a valid word also 
removes the letters of the word from the rack object and returns a string containing the remaining letters.*/
        public string PlayWord(string candidate)
        {
            throw new NotImplementedException();
        }

/*SwapAll() method does nothing if either the rack or the bag have fewer than seven tiles, otherwise it discards the rack’s current tiles and takes seven new
tiles from the bag. The method also returns a string containing all the rack’s letters on completion of the method call.*/
        public string SwapAll()
        {
            throw new NotImplementedException();
        }

/*TopUp() method does nothing if the rack already has seven tiles or if the bag is empty, otherwise it adds new tiles to the rack from the bag until either the rack
contains seven tiles or the bag is empty. The method also returns a string containing all the rack’s letters on completion of the method call. */
        public string TopUp()
        {
            throw new NotImplementedException();
        }

        /*ToString() method simply returns a string containing all the rack’s letters. This method will override the existing inherited ToString() method.*/
        public override string ToString()
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
