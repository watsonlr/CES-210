/********
CSE212 
(c) BYU-Idaho
01-Prove - Problem 2

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  01-Prove - Problem 2");  // Comment out this line
//  function rotate_list_right(data, amount):
    /*
    Rotate the 'data' to the right by the 
    'amount'.   For example, if the data is 
    [1, 2, 3, 4, 5, 6, 7, 8, 9] and an amount
    is 5 then the list returned should be 
    [5, 6, 7, 8, 9, 1, 2, 3, 4].  The value 
    of amount will be in the range of 1 and 
    len(data).   This is a 'circular rotation'.

    The resulting list should be returned
    Pseudo code  (3 examples)
    print(rotate_list_right([1,2,3,4,5,6,7,8,9],1)) ==>
        should give ==> [9, 1, 2, 3, 4, 5, 6, 7, 8]

    print(rotate_list_right([1,2,3,4,5,6,7,8,9],5)) ==>
        should give ==> [5, 6, 7, 8, 9, 1, 2, 3, 4]

    print(rotate_list_right([1,2,3,4,5,6,7,8,9],9)) ==>
        should give ==> [1, 2, 3, 4, 5, 6, 7, 8, 9]
    */
    int[] example_data = {1,2,3,4,5,6,7,8,9};

    rotatable_class rotate_reg = new rotatable_class();

    // print(rotate_list_right([1,2,3,4,5,6,7,8,9],9)) ==>
    //int[] rotate_1= rotate_reg.right_circular_rotate(example_data,1);
    // int[] rotate_2 = rotate_reg.right_circular_rotate(example_data,5);
    // int[] rotate_3 = rotate_reg.right_circular_rotate(example_data,9);

    List<int> rotate_list = new List<int>() { 1, 5, 9};
																
    Console.WriteLine("UNRotated:  ");
    PrintArray(example_data);
    foreach(int rotate_amount in rotate_list) {
        int[] rotated = rotate_reg.right_circular_rotate(example_data,rotate_amount);
        Console.WriteLine("------------");
        Console.WriteLine("Rotating:" + rotate_amount);
        PrintArray(rotated);
        }
    
    void PrintArray(int[] toprint) {
        Console.Write("[");
        Console.Write($"{ string.Join(",", toprint)}");
        Console.WriteLine("]");
        }

    class rotatable_class {
        public int[] right_circular_rotate(int[] data,int amount) {
            int[] rotatable = data;
            int carry;
            for(int i=1;(i<=amount);i++) {
                carry = rotatable[data.Length-1];
                for(int e=data.Length-1;e>0;e--) {
                       rotatable[e] = rotatable[e-1];
                    }
                rotatable[0] = carry;
                }
            return rotatable;
            }
        }