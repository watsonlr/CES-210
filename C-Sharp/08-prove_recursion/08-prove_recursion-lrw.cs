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
    static int sum_squares_recursive(int n)
        {
            int totalSum;
            if (n > 0)
                { totalSum = n*n +sum_squares_recursive(n-1); }
            else if (n == 1)
                { totalSum = 1; }
            else
                { totalSum = 0; }
            return totalSum; 
        }
    bool test(int n_in, int the_answer)
        {
        int got_answer= sum_squares_recursive(n_in);
        Console.WriteLine("SSR of " + n_in +" is: " + got_answer);
        return (got_answer == the_answer);
        }
    public bool test_all() 
        {
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        return ((test(10,385)) && (test(100,338350)));
        }
    }

///////////////////
//   Problem 2 # //
///////////////////
    class problem2 {
    public List<string> permutations_choose(letters, size, word="")
        {
        List<string> a = {}
            return 

        }

    }
    
    /*
    Using recursion print permutations of length
    'size' from a list of 'letters'.  This function
    should assume that each letter is unique (i.e. the 
    function does not need to find unique permutations).

    In mathematics, we can calculate the number of permutations
    using the formula: len(letters)! / (len(letters) - size)!

    For example, if letters was [A,B,C] and size was 2 then
    the following would display: AB, AC, BA, BC, CA, CB (might be in 
    a different order).

    You can assume that the size specified is always valid (between 1 
    and the length of the letters list).
    */

// Sample Test Cases (may not be comprehensive) 
print("\n=========== PROBLEM 2 TESTS ===========")
permutations_choose(list("ABCD"),3)
/*
Expected Result (order may be different):
ABC
ABD
ACB
ACD
ADB
ADC
BAC
BAD
BCA
BCD
BDA
BDC
CAB
CAD
CBA
CBD
CDA
CDB
DAB
DAC
DBA
DBC
DCA
DCB
*/

print("---------")
permutations_choose(list("ABCD"),2)  
/*
Expected Result (order may be different):
AB
AC
AD
BA
BC
BD
CA
CB
CD
DA
DB
DC
*/
print("---------")         
permutations_choose(list("ABCD"),1)
/* 
Expected Result (order may be different):
A
B
C
D
*/

