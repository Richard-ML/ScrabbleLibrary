/**********************************************************************************
 * Program:         ScrabbleLibrary.dll                                           *
 * Module:          IApplication.cs                                               *
 * Date:            Feb 11, 2016                                                  *
 * Author(s):       Richard Mills-Laursen & Craig MacLeod                         *
 * Student Number:  0639240 & #######                                             *
 * Description:     Represents a Scrabble bag.                                    *
 *                                                                                *
 **********************************************************************************/
using Microsoft.Office.Interop.Word;

namespace ScrabbleLibrary
{

    /*
This interface is obtained by constructing an object of type Microsoft.Office.Interop.Word.Application.
The CheckSpelling() method also has several optional parameters but only an argument for the word parameter must be provided when calling it. Note that only words in lowercase format will be properly spellchecked.

The Microsoft Word 15.0 Object Library is an existing unmanaged (COM) component that will already be installed and
registered on any Windows computer that has Microsoft Office 2013 installed and will be used to spellcheck words to ensure they are valid.
    */
    interface IApplication: Application
 {
        bool CheckSpelling(string Word);

       
        //object j Microsoft.Office.Interop.Word.Application;

        //       [DispId(324)]
        // System.Boolean CheckSpelling(System.String Word, ref System.Object CustomDictionary, ref System.Object IgnoreUppercase, ref System.Object MainDictionary, ref System.Object CustomDictionary2, ref System.Object CustomDictionary3, ref System.Object CustomDictionary4, ref System.Object CustomDictionary5, ref System.Object CustomDictionary6, ref System.Object CustomDictionary7, ref System.Object CustomDictionary8, ref System.Object CustomDictionary9, ref System.Object CustomDictionary10);
        //Word._Application.CheckSpelling(string Word);

    }
}
