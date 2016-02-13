/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          Bag.cs                                                        *
 * Date:            Feb 11, 2016                                                  *
 * Author(s):       Richard Mills-Laursen & Craig MacLeod                         *
 * Student Number(s):  0639240 & #######                                          *
 * Description:     Implementation class for the Scrabble bag interface.          *
 *                                                                                *
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
