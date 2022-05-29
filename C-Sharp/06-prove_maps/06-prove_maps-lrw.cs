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





/****  Problem 2:  Degree instances  ****/
Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
summarize_degrees grad_info = new summarize_degrees();
string census_file = "./census.txt";
grad_info.read_file(census_file);   // You might need to add a path for the file
grad_info.summarize();              // Printout everything

/*************************/ 
Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========");
anagram_check anagram_checker = new anagram_check();
anagram_checker.show_anagram("CAT","ACT"); //# True
anagram_checker.show_anagram("DOG", "GOOD") ;//# False
anagram_checker.show_anagram("AABBCCDD", "ABCD"); //# False
anagram_checker.show_anagram("ABCCD","ABBCD"); //# False
anagram_checker.show_anagram("BC","AD"); //# False
anagram_checker.show_anagram("Ab","Ba"); //# True
anagram_checker.show_anagram("A Decimal Point", "Im a Dot in Place");  //# True
anagram_checker.show_anagram("tom marvolo riddle", "i am lord voldemort"); //# True
anagram_checker.show_anagram("Eleven plus Two", "Twelve Plus One"); //# True
anagram_checker.show_anagram("Eleven plus One", "Twelve Plus One"); //# False


Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========");

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
        public Dictionary<string, int> degrees = new Dictionary<string, int>();
        int counter=0;
        
        public void read_file(string filename) {
        int degree_field = 3;
        string the_degree;
        /*
        The Dictionary is going to be {field_name, count}
        Read the file, separate into fields (CSV), 4th field is degree name.

        If the degree name exists, augment the count.
        If it doesn't exist, add an entry with count=1
        */

        if (File.Exists(filename)) {
            foreach(string line in System.IO.File.ReadLines(filename))
                {
                string[] textSplit = line.Split(",");
                // System.Console.WriteLine(line);  
                the_degree = textSplit[degree_field];
                if (degrees.ContainsKey(the_degree))
                    {
                        degrees[the_degree]++;   // There is an entry, just increment the count
                    } else {
                    degrees.Add(the_degree,1);   // No entry yet, so add it to the dictionary
                    }
                counter++;  
                }
            } else {
                System.Console.WriteLine("File: " + filename + " doesn't exist");  
                return;
            }
        }
        public void summarize() {
            // This prints out the keys/values of the dictionary, sort optional
            foreach(var pair in degrees)
            {
            Console.WriteLine($"{pair.Key}: Count={pair.Value}  ");
            }
            return;
            }
        }


// #############
// # Problem 3 #
// #############



class anagram_check
    {
    /* 
    Determine if 'word1' and 'word2' are anagrams.  An anagram
    is when the same letters in a word are re-organized into a 
    new word.  A Python dictionary is used to solve the problem.

    Examples:
    is_anagram("CAT","ACT") would return True
    is_anagram("DOG","GOOD") would return False because GOOD has 2 O's

    Important Note: When determining if two words are anagrams, you
    should ignore any spaces.  You should also ignore cases.  For 
    example, 'Ab' and 'Ba' should be considered anagrams

    */
    public void show_anagram(string word1, string word2)
        {
            Console.Write("Comparing: '" + word1 + "' and '");
            Console.WriteLine(word2 + "\t\t Anagram is: " + this.is_anagram(word1,word2));
        }

    public bool is_anagram(string word1, string word2)
        {
        bool match=true;
        string WORD1; string WORD2;   // Uppercase, stripped of spaces
        WORD1 = word1.Replace(" ",string.Empty).ToUpperInvariant();
        WORD2 = word2.Replace(" ",string.Empty).ToUpperInvariant();
        letter_count word1dict = new letter_count(WORD1);
        letter_count word2dict = new letter_count(WORD2);
        foreach(var aletter in word1dict.the_letters.Keys) {
            if (word2dict.the_letters.ContainsKey(aletter)) {
            // matching until proven not
            match &= (word1dict.the_letters[aletter] == word2dict.the_letters[aletter]);
            } else {
                match = false;  // a letter that's in word1 and not word2
                }
            }
        return match;
        // now compare the dictionaries and see if each letter is used the same number of times.
        }

    public class letter_count{
        public Dictionary<char, int> the_letters = new Dictionary<char, int>();
        public letter_count(string wordin) {
            foreach(char letter in wordin) {
                if(the_letters.ContainsKey(letter)) {
                    the_letters[letter]++;}
                else {
                    the_letters.Add(letter,1);
                    }
                }
            }
        }
    }


/*
# Sample Test Cases (may not be comprehensive) 
print("\n=========== PROBLEM 3 TESTS ===========")
print(is_anagram("CAT","ACT")) # True
print(is_anagram("DOG", "GOOD")) # False
print(is_anagram("AABBCCDD", "ABCD")) # False
print(is_anagram("ABCCD","ABBCD")) # False
print(is_anagram("BC","AD")) # False
print(is_anagram("Ab","Ba")) # True
print(is_anagram("A Decimal Point", "Im a Dot in Place"))  # True
print(is_anagram("tom marvolo riddle", "i am lord voldemort")) # True
print(is_anagram("Eleven plus Two", "Twelve Plus One")) # True
print(is_anagram("Eleven plus One", "Twelve Plus One")) # False
*/