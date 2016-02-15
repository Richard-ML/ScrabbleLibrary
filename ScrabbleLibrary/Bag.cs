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


/*ScrabbleLibrary
  Must be implemented as a class library assembly using C#
  Must work with your own .NET client
  Must work fully with the Excel client provided (ScrabbleExcelClient.xlsm) without making any changes to the client except to add a reference to your own
   ScrabbleLibrary assembly’s type library (a type library for your ScrabbleLibrary will be generated and registered automatically if you configure the project properties required to use it via COM Interop).
  Must recognize letters in UPPERCASE format. May optionally recognize lowercase letters as well

    */
namespace ScrabbleLibrary
{
    public class Bag : IBag
    {
        private Dictionary<char, int> letterValue = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 3 }, { 'c', 3 }, { 'd', 2 }, { 'e', 1 }, { 'f', 4 }, { 'g', 2 }, { 'h', 4 }, { 'i', 1 }, { 'j', 8 }, { 'k', 5 }, { 'l', 1 }, { 'm', 3 }, { 'n', 1 }, { 'o', 1 }, { 'p', 3 }, { 'q', 10 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'u', 1 }, { 'v', 4 }, { 'w', 4 }, { 'x', 8 }, { 'y', 4 }, { 'z', 10 } };
        private List<char> letters = new List<char>();//The char contents of the bag
        private List<string> rack = new List<string>();//The string contents of each rack
        public int currPlayer = 1;//Current players turn defaulted to player one.
        public int numPlayers = 2;//Ammount of players playing (2-4)



        public Bag()
        {
            //Setup the bag by populating it with randomly selected elements from the defulat list of characters in scrabble
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

            //Shuffle characters into the letters list and remove them from the default collection of characters
            Random rNum = new Random();
            int randNum;
            while (temp.Count > 0)
            {
                randNum = rNum.Next(0, temp.Count);
                letters.Add(temp[randNum]);
                temp.RemoveAt(randNum);
            }

            //Setup the racks for the two default/minimum scrabble players
            NewRack();
            NewRack();

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
            //TODO: Add spellcheck!! 
            string result = rack[currPlayer - 1];//Copy the rack so we can remove each character as it is matched without effecting the origial data until we confirm it is a valid word
            bool valid = true;
            for (int candiChar = 0; candiChar < candidate.Length; candiChar++)
            {
                bool containsChar = false;
                for (int nc1 = 0; nc1 < result.Length; nc1++)
                {
                    if (result[nc1] == candidate[candiChar])
                    {
                        containsChar = true;
                        string temp = "";
                        for (int tempChar = 0; tempChar < result.Length; tempChar++)
                            if (tempChar != nc1)
                                temp += result[tempChar];
                        result = temp;
                        goto outOfFor;//Break out of current look to prevent multiple characters from being removed
                    }
                }
                outOfFor:
                if (containsChar == false)
                    valid = false;
            }
            if(valid == true)
            {
                rack[currPlayer - 1] = result;
            }
            return rack[currPlayer - 1];
        }

        /*SwapAll() method does nothing if either the rack or the bag have fewer than seven tiles, otherwise it discards the rack’s current tiles and takes seven new
        tiles from the bag. The method also returns a string containing all the rack’s letters on completion of the method call.*/
        public string SwapAll()
        {
     
                    if (rack[currPlayer-1].Length >= 7)
                    {
                        if (letters.Count >= 7)
                        {
                            rack[currPlayer-1] = "";//Discard current letters in rack
                            TopUp();
                        }
                    }
            return rack[currPlayer - 1];
        }

        /*TopUp() method does nothing if the rack already has seven tiles or if the bag is empty, otherwise it adds new tiles to the rack from the bag until either the rack
        contains seven tiles or the bag is empty. The method also returns a string containing all the rack’s letters on completion of the method call. */
        public string TopUp()
        {
            while (rack[currPlayer-1] == null || rack[currPlayer-1].Length < 7)
                if (letters.Count > 0)
                {
                    rack[currPlayer-1] += letters[0];
                    letters.RemoveAt(0);

                }
            return rack[currPlayer-1];
        }


        /*ToString() method simply returns a string containing all the rack’s letters. This method will override the existing inherited ToString() method.*/
        public override string ToString()
        {
            return rack[currPlayer];
        }


        IRack IBag.NewRack()
        {/*
            int tempPlayersTurn = currPlayer; //Create a temp variable to ensure once this code is run that it is still that players turn
            if (numPlayers < 4)
            {
                numPlayers++;
                currPlayer = numPlayers;//Set the curPlayer to the new player so the TopUp method fills up their rack
                rack.Add("");//Add a rack to the rack object/string list
                TopUp();//Fill the new players rack with letters
                currPlayer = tempPlayersTurn;//restore to the correct players turn

            }

            */
            return null;// The maximum amount of player racks have already been created.
        }


        public string NewRack()
        {

            int tempPlayersTurn = currPlayer; //Create a temp variable to ensure once this code is run that it is still that players turn
            if (numPlayers < 4)
            {
                numPlayers++;
                currPlayer = numPlayers;//Set the curPlayer to the new player so the TopUp method fills up their rack
                rack.Add("");//Add a rack to the rack object/string list
                TopUp();//Fill the new players rack with letters
                currPlayer = tempPlayersTurn;//restore to the correct players turn
                return rack[numPlayers - 1];
            }


            return null;// The maximum amount of player racks have already been created.
        }
    }
}
