/********
CSE212 
(c) BYU-Idaho
05-Prove - Problem 1

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  05-Prove - Problem 1");  // Comment out this line


class set_operations{
    public int[] intersection (int[] set1, int[] set2) {
        /*
        Perform an intersection between 2 sets.  An intersection will contain
        the items in common between both sets.  Do not use the set 
        operators (+, -, *, &, |) and functions (intersection, union) that are built-in to CSharp's HashSet.
        */
        int[] the_intersection = {};
        foreach (int i in set1) {
            if (!set2.Contains(i)) {
                the_intersection.Append(i);
            }
        return the_intersection;
        }
    public int[] union (int[] set1, int[] set2) {
        /*
        Perform a union between 2 sets.  A union will contain all the items
        from both sets.   Do not use the set operators (+, -, *, &, |)
        and functions (intersection, union) that are built-in to CSharp's HashSet.
        */
        int[] the_union = set1;  // Making an assumption that the array coming in IS a set (no duplicates)

        foreach (int i in set2) {
            if (!the_union.Contains(i)) {
                the_union.Append(i);
            }
            }
        return the_union;
    }
    public bool test(int[] testing_in, int[] answer_in) {
        // To make sure they are sets, I'll use the built-in method, convert them both, and compare
        HashSet<int> t = testing_in.ToHashSet();
        HashSet<int> a = answer_in.ToHashSet();
        return (t==a);
        }
    public void do_all_tests(){
        // Just goes thru a couple of test cases, checks to see that they pass and prints the status
        bool passed = true;
        int[] s1 = {1,2,3,4,5}; int[] s2 = {4,5,6,7,8};
        int[] intersect1_ans = {4,5}; int[] union1_ans = {1, 2, 3, 4, 5, 6, 7, 8};
        // Test 1
        passed &= test(intersection(s1,s2),intersect1_ans);
        passed &= test(union(s1,s2),union1_ans);
        // Test 2
        int[] t1 = {1,2,3,4,5}; int[] t2 = {6,7,8,9,10};
        int[] intersect2_ans = {}; int[] union2_ans = {1, 2, 3, 4, 5, 6, 7, 8,9,10};
        passed &= test(intersection(t1,t2),intersect2_ans);
        passed &= test(union(t1,t2),union2_ans);

        if (passed) {
            Console.WriteLine("Congratulations!  Tests Passed");}
            else {
            Console.WriteLine("TESTS Failed");
            }
        }
    }