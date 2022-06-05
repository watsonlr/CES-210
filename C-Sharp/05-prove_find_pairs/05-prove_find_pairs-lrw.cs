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

prove_find_pairs testThem = new prove_find_pairs().tests;

class prove_find_pairs {

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
        wordSet.Add(word);
        string rev_word = string.Concat(word[1],word[0]);
        if (wordSet.Contains(rev_word)) {
            pairs.Add(word + " & " + rev_word);
            }
        // now check to see if the reverse is already in there
        return pairs;
        }
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

    public bool test(string[]wordlist,answer_pairs)

    public bool test(wordlist,answer_paris)
    public bool tests{
    public bool tests{
        
        return true;
    }
}

find_pairs(["am","at","ma","if","fi"])      # ma & am, fi & if
print("=============")
find_pairs(["ab", "bc", "cd", "de", "ba"])  # ba & ab
print("=============")
find_pairs(["ab","ba","ac","ad","da","ca"]) # ba & ab, da & ad, ca & ac
print("=============")
find_pairs(["ab", "ac"])                    # None
print("=============")
find_pairs(["ab", "aa", "ba"])              # ba & ab
print("=============")
find_pairs(["23","84","49","13","32","46","91","99","94","31","57","14"])
                                            # 32 & 23, 94 & 49, 31 & 13