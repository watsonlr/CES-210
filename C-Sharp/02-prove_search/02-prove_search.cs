/********
CSE212 
(c) BYU-Idaho
02-Prove - Problem 2

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  02-Prove - Problem 2");  // Comment out this line

var watch = new System.Diagnostics.Stopwatch();
            
void showTimer() {
    watch.Start();
for (int i = 0; i < 10000; i++)
{
    Console.Write(i);
}
Console.WriteLine();
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
}



/**********************************************/
int search_sorted_1(int[] data, int target) {
/**********************************************/
    /* 
    Search for 'target' in the list 'data'
    When its found (or not found) the variable count
    which represents the work done in the function 
    is returned.
   */ 
    int count = 0;
    foreach(int item in data) {
        count++;
        if (item == target) {
            break;
            // return count; // Found it
            }
    return count // Didn't find it
    }
    
int sorted_2(data, target) {
    /* Search for 'target' in the list 'data'
    When its found (or not found) the variable count
    which represents the work done in the function 
    is returned.
     */

    if len(data) == 0:
        return 1     # All done
    middle = len(data) // 2
    if data[middle] == target:
        return 1     # Found it
    elif data[middle] < target:   # Search in the upper half after index middle
        return 1 + search_sorted_2(data[middle+1:], target)
    else:                         # Search in the lower half before index middle
        return 1 + search_sorted_2(data[:middle], target)

# This code will analyze the the 2 sorting functions for different values of "n" (size of the data)
print("{:>15}{:>15}{:>15}{:>15}{:>15}".format("n","sort1-count","sort2-count","sort1-time","sort2-time"))
print("{:>15}{:>15}{:>15}{:>15}{:>15}".format("-"*10,"-"*10,"-"*10,"-"*10,"-"*10))
for n in range(0,10001,100):
    test_data = [x for x in range(n)]
    count1 = search_sorted_1(test_data, n)
    count2 = search_sorted_2(test_data, n)
    time1 = timeit.timeit("search_sorted_1(test_data, n)", number=100, globals=globals()) / 100 * 1000
    time2 = timeit.timeit("search_sorted_2(test_data, n)", number=100, globals=globals()) / 100 * 1000
    print("{:>15}{:>15}{:>15}{:>15.5f}{:>15.5f}".format(n, count1, count2, time1, time2))





showTimer();


