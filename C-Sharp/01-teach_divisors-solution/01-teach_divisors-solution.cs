/********
CSE212 
(c) BYU-Idaho
01-Teach - Problem 1 - Solution

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  01-Teach - Problem 1 - Solution");  // Comment out this line

/* 
def find_divisors_1(number):
    /*
    Create a list of all divisors for a number including 1
    and excluding the number itself.  Modulo will be used
    to test divisibility.
    Test all numbers from 1 to number-1.

    Actually, we can be more efficient with range(1, (number//2)+1)
    */

/*   TO REPLACE
def find_divisors_2(number):
    """
    Same as find_divisors_1 but a list comprehension is used.
    """
    divisors = [n for n in range(1, number) if number % n == 0]
    return divisors
*/

// int[] find_divisors_1(int number) {
List<int> find_divisors_1(int number) {
    List<int> find_them = new List<int>();
    //make instance of the list_type
    int found = 0;

    for(int divisor=1;(divisor<=number);divisor++) {
        if (number % divisor == 0) {find_them.Append(number);}
        found++;
        }
    Console.WriteLine("Found: " + found);
    return find_them;
    }

/* 
int[] find_divisors_2(int number) {
    int[] find_them = new List<int>();
    for(int divisor=1;(divisor<=number);divisor++) {
        if (number % divisor == 0) {find_them.Append(number);}
        }
    return find_them;
    }
*/

List<int> answer = find_divisors_1(80); // Answer should be:   [1, 2, 4, 5, 8, 10, 16, 20, 40]
// Console.WriteLine(find_divisors_1(80)); // Answer should be:   [1, 2, 4, 5, 8, 10, 16, 20, 40]
// Console.WriteLine(find_divisors_2(80)); // Answer should be:   [1, 2, 4, 5, 8, 10, 16, 20, 40]
// Console.WriteLine(find_divisors_1(79)); // Answer should be:   [1] ... This is prime
// Console.WriteLine(find_divisors_2(79)); // Answer should be:   [1]