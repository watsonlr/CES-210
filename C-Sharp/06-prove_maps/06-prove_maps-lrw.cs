/********
CSE212 
(c) BYU-Idaho
06-Prove

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  06-Prove");  // Comment out this line






/****  Problem 1:  Language Translator  ****/
/****  Problem 1:  Testing *******/

// Sample Test Cases (may not be comprehensive) 
Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
Translator english_to_german = new Translator();
Translator korean_to_english = new Translator();
english_to_german.add_word("House","Haus");
english_to_german.add_word("Car","Auto");
english_to_german.add_word("Plane","Flugzeug");

korean_to_english.add_word("cheep","House");
korean_to_english.add_word("pihengi","Plane");
korean_to_english.add_word("chadongcha","Car");

Console.WriteLine("Translating to German: 'Car' : " + english_to_german.translate("Car"));  // Auto
Console.WriteLine("Translating to German: 'Plane' : " + english_to_german.translate("Plane"));  // Auto

Console.WriteLine("Translating from Korean: 'cheep' : " + korean_to_english.translate("cheep"));  // House
Console.WriteLine("Translating from Korean: 'pihengi' : " + korean_to_english.translate("pihengi"));  // Plane
Console.WriteLine("Translating from Korean: 'chadongcha' : " + korean_to_english.translate("chadongcha"));  // Car


public class Translator
{
    /* 
    This class provides the capability of a translator.  A
    Python Dictionary is used to keep track of the mapping 
    of words from one language to another language.  You should 
    assume that there is only one translation for every 
    word (and vice versa).
    */
    public Dictionary<string, string> words = new Dictionary<string, string>();

    public void add_word(string from_word, string to_word)
        {
        /* Add the translation from 'from_word' to 'to_word'
        For example, in a english to german dictionary:
        my_translator.add_word("book","buch")
        */
        words.Add(from_word,to_word);
        return;

        }
    public string translate(string from_word) {
        /* 
        Translate a word and return the result.  If the word 
        can not be translated then "???" is returned.  
        For example, in an english to german dictionary:
            german_word = my_translator.translate("book")
       */
       string xlated;
        if(words.TryGetValue(from_word, out xlated)) {
            return(xlated);
            } else {
            return "???";
            }
        }


    public class
}