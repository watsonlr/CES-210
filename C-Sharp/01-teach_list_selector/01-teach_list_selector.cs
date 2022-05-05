/********
CSE212 
(c) BYU-Idaho
01-Teach - Problem 2

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  01-Teach - Problem 2");  // Comment out this line

/* 
//     The list1 and list2 inputs will be combined into a single
//     list.  The order in which they are added is determined by 
//     the selector list.  The selector list will only contain
//     the values 1 or 2.  A value of 1 means to select the next
//     value from list 1.  A value of 2 means to select the next 
//     value from list 2.  It is assumed that the selector list
//     will not contain any invalid values and it is also assumed
//     that the sizes of list1 and list2 agree with the selector 
//     list.
*/

List<object> list_selector(List<object> list1, List<object> list2, int[] selector) {
    var pos_list1 = 0;
    var pos_list2 = 0;
    var result = new List<object>();
    foreach (int s in selector) {
        if (s == 1) {
            // If we need to select from list 1, then add
            // the value at the current list 1 position. 
            result.Add(list1[pos_list1]);
            // Move the position for list 1 to the next value
            pos_list1 += 1;
        } else if (s == 2) {
            // If we need to select from list 2, then add 
            // the value at the current list 2 position
            result.Add(list2[pos_list2]);
            // Move the position for list 2 to the next value
            pos_list2 += 1;
        }
    }
    return result;
}
// Print the List
// ******************************** //
 void PrintList(List<int> toprint) {
// ******************************** //
        Console.Write("[");
        for(int i=0;i<toprint.Count;i++)
            {
                if (i==(toprint.Count-1))
                    {Console.WriteLine(toprint[i] + "]");}
                else {Console.Write(toprint[i] + ", ");}
            }
        }

// Numbers first
var l1 = new List<object> { 1, 2, 3, 4, 5 };
var l2 = new List<object> { 2, 4, 6, 8, 10 };
int[] select = { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
PrintList(list_selector(l1,l2,select));

// Now characters 
l1 = new List<object> { "A", "A", "A", "A", "A" };
l2 = new List<object> { "B", "B", "B", "B", "B" };
int[] select = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
PrintList(list_selector(l1,l2,select));
