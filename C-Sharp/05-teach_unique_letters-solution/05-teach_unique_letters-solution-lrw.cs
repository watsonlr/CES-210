/********
CSE212 
(c) BYU-Idaho
05-Teach - Problem 1 - Solution

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  05-Teach - Problem 1 - Solution");  // Comment out this line

namespace Namespace {
    
    using System.Collections.Generic;
    
    public static class Module {
        
        //  
        //     Determine if there are any duplicate letters in the text provided.
        //     This solution should use a set and result in O(n) performance.
        //     
        public static object unique_letters(object text) {
            var found = new HashSet<object>();
            foreach (var letter in text) {
                // Look in set to see if letter was seen before
                if (found.Contains(letter)) {
                    return false;
                }
                // Otherwise we will add it to the set and move on
                found.add(letter);
            }
            // If we made it this far then all letters were unique
            return true;
        }
        
        // An alternative solution:
        //  
        //     Determine if there are any duplicate letters in the text provided.
        //     This solution should use a set and result in O(n) performance.
        //     
        public static object unique_letters2(object text) {
            var unique = new HashSet<object>();
            foreach (var letter in text) {
                unique.add(letter);
            }
            // The above three lines can be simplified to just: unique = set(text)
            // If the text has only unique letters, then the unique set should
            // be the same size of the text string.
            return unique.Count == text.Count;
            // We could simplify this function to a single line:
            // return len(set(text)) == len(text)
        }
        
        public static object test1 = "abcdefghijklmnopqrstuvwxyz";
        
        public static object test2 = "abcdefghijklanopqrstuvwxyz";
        
        public static object test3 = "";
    }
}