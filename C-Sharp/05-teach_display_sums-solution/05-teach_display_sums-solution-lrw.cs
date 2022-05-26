/********
CSE212 
(c) BYU-Idaho
05-Teach - Problem 2 - Solution

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  05-Teach - Problem 2 - Solution");  // Comment out this line

    /*
    Display pairs of numbers that sum to 10 using a set in O(n) time
    We are assuming that there are no duplicates in the list
    */



int[] test1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10} ; 
int[] test2 = {-20, -15, -10, -5, 0, 5, 10, 15, 20} ;
int[] test3 = {5, 11, 2, -4, 6, 8, -1} ;
/* Should show something like (order does not matter):
    6 4
    7 3
    8 2
    9 1 
    */ 


Console.WriteLine("====test1======="); display_sums(test1) ;
// Console.WriteLine("====test2======="); display_sums(test2) ;
// Console.WriteLine("====test3======="); display_sums(test3);
// Console.WriteLine("====   DONE  =======");
/*
Should show something like (order does not matter):
    10 0
    15 -5
    20 -10
 */

/* """
Should show something like (order does not matter):
    8 2
    -1 11
*/

void display_sums(int[] numbers) {
    // bool is_in;
    List<int> values_seen = new List<int>();
    foreach(var n in numbers)
        {
        /*  If 10-n is in the values_seen set then I know that
             I have previously seen a number that will sum with n 
            to equal 10.  Display that pair
        */

        Console.WriteLine("Looking at: " + n);
        // Console.WriteLine("Values Seen:" + values_seen);
         values_seen.ForEach(x=>x.Print());

        if (values_seen.Contains(10-n))
            {
            Console.Write("::: " + n + " :::: "); Console.WriteLine((10-n));
            }
            values_seen.Append(n); // Add this number to the values_seen set 
            Console.WriteLine("             Appended: " + n);
        }
    }