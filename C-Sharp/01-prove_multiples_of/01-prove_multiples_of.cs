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
float[] multiples_of(double number, int length) {
    float[] toreturn = new float[length];
        foreach (var i in Enumerable.Range(1, length )) {
            toreturn.append(i * number);
        return toreturn;



    }
static object hold(double number, int length) {
        var toreturn = new List<object>();
        foreach (var i in Enumerable.Range(1, length )) {
            toreturn.append(i * number);
        }
        return toreturn;
    }

Console.WriteLine(multiples_of(7, 5));    // [7, 14, 21, 28, 35]
Console.ReadLine();
/*
Console.WriteLine(multiples_of(1.5, 10)); //  [1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0]
Console.WriteLine(multiples_of(-2, 10));  //  [-2, -4, -6, -8, -10, -12, -14, -16, -18, -20]
*/
}