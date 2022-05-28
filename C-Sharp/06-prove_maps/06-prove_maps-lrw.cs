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

Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
summarize_degrees grad_info = new summarize_degrees();

grad_info.read_file("degrees.txt");


/*********  Used for PROBLEM 1 **************/
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
}



/*********  Used for PROBLEM 2 **************/
    public class summarize_degrees {
        public Dictionary<string, string> fields = new Dictionary<string, string>();
        int counter=0;
        public void read_file(string filename) {

        foreach(string line in System.IO.File.ReadLines(filename))
            {
            System.Console.WriteLine(line);  
            counter++;  
            }
        }
    }  


    /* 
    Read a census file and summarize the degrees (education)
    earned by those contained in the file.  The summary
    should be stored in a dictionary where the key is the
    degree earned and the value is the number of people that 
    have earned that degree.  The degree information is in
    the 4th column of the file.  There is no header row in the
    file.
    degrees = dict()
    with open(filename) as file_in:
        for line in file_in:
            fields = line.split(",") 

            # ADD YOUR CODE HERE

    return degrees

/* # Sample Test Cases (may not be comprehensive) 
print(summarize_degrees("census.txt")) # You might need to add a path for the file
# Results may be in a different order:
# {'Bachelors': 5355, 'HS-grad': 10501, '11th': 1175, 
# 'Masters': 1723, '9th': 514, 'Some-college': 7291, 
# 'Assoc-acdm': 1067, 'Assoc-voc': 1382, '7th-8th': 646, 
# 'Doctorate': 413, 'Prof-school': 576, '5th-6th': 333, 
# '10th': 933, '1st-4th': 168, 'Preschool': 51, 
# '12th': 433}   
*/


}