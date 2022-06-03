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
            {//string compare1 = got_answer.TakeLast;
            }
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
///////////////////
//   Problem 3 # //
///////////////////

class problem3 {

int count_ways_to_climb(int s, int remember ){
    /*
    Imagine that there was a staircase with 's' stairs.  
    We want to count how many ways there are to climb 
    the stairs.  If the person could only climb one 
    stair at a time, then the total would be just one.  
    However, if the person could choose to climb either 
    one, two, or three stairs at a time (in any order), 
    then the total possibilities become much more 
    complicated.  If there were just three stairs,
    the possible ways to climb would be four as follows:
    
        1 step, 1 step, 1 step
        1 step, 2 step
        2 step, 1 step
        3 step

	With just one step to go, the ways to get
    to the top of 's' stairs is to either:
    
    - take a single step from the second to last step, 
    - take a double step from the third to last step, 
    - take a triple step from the fourth to last step

    We don't need to think about scenarios like taking two 
    single steps from the third to last step because this
    is already part of the first scenario (taking a single
    step from the second to last step).

    These final leaps give us a sum:

    count_ways_to_climb(s) = count_ways_to_climb(s-1) + 
                             count_ways_to_climb(s-2) +
                             count_ways_to_climb(s-3)

    To run this function for larger values of 's', you will need
    to update this function to use memoization.  The parameter
    'remember' has already been added as an input parameter to 
    the function for you to complete this task.
    
    The last test case is commented out because it will not work
    until the memoization is implemented.
    */
    // Base Cases
    int ways;
    if (s <= 4) { return s;}
    // # Solve using recursion
    else
        {
        ways = count_ways_to_climb(s-1) + count_ways_to_climb(s-2) + count_ways_to_climb(s-3);
        }
        return ways;
    }

// Sample Test Cases (may not be comprehensive) 
    public bool test(int ways_to_climb){
    Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========")
    Console.WriteLine(count_ways_to_climb(5));   # 13
    Console.WriteLine(count_ways_to_climb(20));  # 121415
    // Uncomment out the test below after implementing memoization.  It won't work without it.
    // Console.WriteLine(count_ways_to_climb(100))  # 180396380815100901214157639
    }
}