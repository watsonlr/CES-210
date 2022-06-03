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

problem2 do_prob2 = new problem2();
if (do_prob2.test_all()) {
    Console.WriteLine("Problem 2 passes");
    } else {
    Console.WriteLine("Problem 2 FAILED");
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

    int factorial(int n)
        {
        int sum=1;
        if (n<=1) {return sum;}
        return n * factorial(n-1);
        }
    public List<string> permutations_choose(string letters, int size)
        {
        List<string> words_found = new List<string>();
        int number_of_words = factorial(letters.Length) / factorial(size);
        Console.WriteLine("Number of combinationsfor " +letters.Length + "/" + size + " is : " + number_of_words);
        return words_found;
        }
    public bool test(string letters, int size, string[] answers)
        {
        List<string> got_answer =  permutations_choose(letters,size);
        // Now test all of combinations against the answers
        while(got_answer.Count >1)
            {string compare1 = got_answer.TakeLast;}
        return true;
        }
    public bool test_all()
        {
        bool passed = true;
        List<string> got_answer = new List<string>();
        string letters = "ABCD";
    // Sample Test Cases (may not be comprehensive) 
        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        // got_answer = permutations_choose(letters,3);
        // Expected Result (order may be different):
        string[] expected1 = {"ABC", "ABD", "ACB", "ACD", "ADB", "ADC", "BAC", "BAD",
                                "BCA", "BCD", "BDA", "BDC", "CAB", "CAD", "CBA", "CBD",
                                "CDA", "CDB", "DAB", "DAC", "DBA", "DBC", "DCA", "DCB"};
        string[] expected2 = {"AB", "AC", "AD", "BA", "BC", "BD", "CA", "CB", "CD", "DA", "DB", "DC"};
        string[] expected3 = {"A", "B", "C", "D" };
        passed &= test(letters,3,expected1);
        passed &= test(letters,2,expected2);
        passed &= test(letters,1,expected3);
            /* Expected Result (order may be different): */
        return passed;
        }
    }