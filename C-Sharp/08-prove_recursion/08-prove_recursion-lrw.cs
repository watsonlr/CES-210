/********
CSE212 
(c) BYU-Idaho
08-Prove - Solutions

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  

This solution should not be shared with students.
//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  08-Prove - Solutions");  // Comment out this line


///////////////////
//   Problem 1 # //
///////////////////
problem1 do_prob1 = new problem1();
if (do_prob1.test_all()) {
    Console.WriteLine("Problem 1 passes");
    } else {
    Console.WriteLine("Problem 1 FAILED");
    }

class problem1
    {
    /*
    Using recursion, find the sum of 1^2 + 2^2 + 3^2 + ... + n^2
    and return it.  Remember to both express the solution 
    in terms of recursive call on a smaller problem and 
    to identify a base case (terminating case).  If the value of
    n <= 0, just return 0.   A loop should not be used.
    */

    int sum_squares_recursive(int n)
        {
        return 0;
        }
    bool test(int n_in, int answer)
        {
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        int the_answer= sum_squares_recursive(n_in);
        Console.WriteLine("SSR of " + n_in +" is: " +);
        return true;
        }
    public bool test_all() 
        {
            return ((test(10,385)) && (test(100,338350)));
        }
    }
