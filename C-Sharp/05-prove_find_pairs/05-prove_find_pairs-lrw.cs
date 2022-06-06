/********
CSE212 
(c) BYU-Idaho
05-Prove - Problem 2

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/

Console.WriteLine("CSE212:  05-Prove - Problem 2");  // Comment out this line

prove_find_pairs testThem = new prove_find_pairs();
string[] test1={"am","at","ma","if","fi"};
string[] test2={"ab", "bc", "cd", "de", "ba"}; //  # ba & ab
string[] test3={"ab","ba","ac","ad","da","ca"}; // # ba & ab, da & ad, ca & ac
string[] test4={"ab", "ac"};//                    # None
string[] test5={"ab", "aa", "ba"};//              # ba & ab
string[] test6={"23","84","49","13","32","46","91","99","94","31","57","14"}; // 32 & 23, 94 & 49, 31 & 13

Console.WriteLine("Test 1 ========= ");
testThem.justprint(test1);
Console.WriteLine("Test 2 ========= ");
testThem.justprint(test2);
Console.WriteLine("Test 3 ========= ");
testThem.justprint(test3);
Console.WriteLine("Test 4 ========= ");
testThem.justprint(test4);
Console.WriteLine("Test 5 ========= ");
testThem.justprint(test5);
Console.WriteLine("Test 6 ========= ");
testThem.justprint(test6);

public class prove_find_pairs {

    HashSet<string> wordSet = new HashSet<string>();
    // HashSet<string> reversed = new HashSet<string>();
    /* 
    Each word is guaranteed to be 2 letters, so it's faster to just swap the letters and check
    instead of some big reversal.   So:
        Add the word to the set
        swap the two letters to make the check word
        see if the check word is in the set
        Can be done in a single pass
    */

    List<string> find_pairs(string[] words)
    {
    List<string> pairs = new List<string>();
    foreach (string word in words) {
        // If the word is just the same 2 characters, then don't add it, because it's not going to have a reversed
        if (word[0] != word[1]) {
            wordSet.Add(word);
        }
        string rev_word = string.Concat(word[1],word[0]);
        if (wordSet.Contains(rev_word)) {
            pairs.Add(word + " & " + rev_word);
            }
        // now check to see if the reverse is already in there
        }
        return pairs;
    }
    /*
    The words parameter contains a list of two character 
    words (lower case, no duplicates). Using sets, find an O(n) 
    solution for displaying all symmetric pairs of words.  

    For example, if words was: [am, at, ma, if, fi], we would display:

    am & ma
    if & fi

    The order of the display above does not matter.  'at' would not 
    be displayed because 'ta' is not in the list of words.

    As a special case, if the letters are the same (example: 'aa') then
    it would not match anything else (remember no the assumption above
    that there were no duplicates) and therefore should not be displayed.
    */

    public void justprint(string[]pairs)
        {
        List<String> found = find_pairs(pairs);
        found.ForEach(p => Console.WriteLine($"   {p}"));
        return;
        }

    public bool test(string[]wordlist,string[] answer_pairs)
        {
            return false;
        }
}