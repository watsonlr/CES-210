/********
CSE212 
(c) BYU-Idaho
01-Prove - Problem 1

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  01-Prove - Problem 1");  // Comment out this line
        // 
        //     This function will produce a list of size 'length' starting
        //     with 'number' followed by multiples of 'number'.  For 
        //     example, multiples_of(7, 5) will result in:
        //     [7, 14, 21, 28, 35].  Assume that length is a positive
        //     integer greater than 0.  The implementation must be
        //     done using a list comprehension.
        //     
List<double> test1 = new List<double>();
test1.Add(1.0D);
test1.Add(2.2D);
test1.Add(3.3D);

/*
static List<double> multiples_of(double number, int length) {
    List<double> toreturn = new List<double>();
    foreach (var i in Enumerable.Range(1, length )) {
        toreturn.Add(i * number);
        }
    return toreturn;
    }
*/

multiples_of_class set1 = new multiples_of_class();
set1.PrintArray(set1.multiples_of(7.0D,5));
set1.PrintArray(set1.multiples_of(1.5D,10));
set1.PrintArray(set1.multiples_of(-2,10));
// set1.PrintArray(the_array);


public class multiples_of_class
    {
    // Storage for the list -- kept in the class, then returned
    // Public method that creates the list when instantiated

    //public List<double> toreturn = new List<double>();
    public int plength;
    public List<double> multiples_of(double number, int length)
        {
        plength = length;
        // public int i = length;
        List<double> toreturn = new List<double>();
        foreach (var i in Enumerable.Range(1, length ))
            { toreturn.Add(i * number); }
        return toreturn;
        }
    public void PrintArray(List<double> toprint){
        int i = 1;
        foreach (var item in toprint) {
            Console.Write(String.Format("  {0:F1}", item));i++;
            if (i<=plength) {Console.Write(",");} else {Console.WriteLine();}
            }
        }
    }
// example1 = new makeMultiplesClass.multiples_of(7,5);




//Console.WriteLine(multiples_of(7,5)[2]);    // [7, 14, 21, 28, 35]
//Console.WriteLine(test1[1]);    // [7, 14, 21, 28, 35]
//Console.WriteLine(multiples_of(7, 5));    // [7, 14, 21, 28, 35]
// Console.ReadLine();
/*
Console.WriteLine(multiples_of(1.5, 10)); //  [1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0]
Console.WriteLine(multiples_of(-2, 10));  //  [-2, -4, -6, -8, -10, -12, -14, -16, -18, -20]
*/
