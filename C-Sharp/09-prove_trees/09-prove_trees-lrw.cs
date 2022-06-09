/********
CSE212 
(c) BYU-Idaho
09-Prove - Problems

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  09-Prove - Problems");  // Comment out this line

public class BST{

    /*
    Implement the Binary Search Tree (BST) data structure.  The Node 
    class below is an inner class.  An inner class means that its real 
    name is related to the outer class.  To create a Node object, we will 
    need to specify BST.Node

    Nodes are only instantiated from within the context of a BST
    */
    public Node root;


    public class Node {

        /*
        Each node of the BST will have data and links to the 
        left and right sub-tree. 
        */
        public int value;
        public Node left;
        public Node right;

        public Node(int newvalue)
            {
            //* Class constructor
            left = null; right = null;
            value = newvalue;
            // The link to this node will be set as right/left, depending on the value compared to the parent
            }
        }

    //###################
    //# Start Problem 1 #
    //###################

        Node place_to_insert(Node starting_at,int datain)
        {
            // Recursive, start and find where this should go
            if (datain < starting_at.value)
                {
                return place_to_insert(starting_at.left,datain);
                } else if (datain > starting_at.value) { 
                return place_to_insert(starting_at.right,datain);
                } else {
                return starting_at;
                }
        }
    
    

        public void insert(int datain)
        /*
        Insert 'data' into the BST.  If the BST
        is empty, then set the root equal to the new 
        node.  Otherwise, use insert to recursively
        find the location to insert.
        The value returned is the pointer to the node we just inserted
        */
        {
        Node to_insert = new Node(datain);
        if (root == null)
            {root=to_insert;
            return;}
        Node insert_at = place_to_insert(root,datain);
        if (datain > insert_at.value)
            {// point the right node
             insert_at.right = to_insert;}
        else if (datain < insert_at.value) {
             insert_at.left = to_insert;
             }
        }
    //#################
    //# End Problem 1 #
    //#################
   

    def __contains__(self, data):
        /* 
        Checks if data is in the BST.  This function
        supports the ability to use the 'in' keyword:

        if 5 in my_bst:
            ("5 is in the bst")

        */
        return self._contains(data, self.root)  # Start at the root

    //###################
    //# Start Problem 2 #
    //###################
     bool contains(Node start_at,int data) {
        /*
        This funciton will search for a node that contains
        'data'.  The current sub-tree being search is 
        represented by 'node'.  This function is intended
        to be called the first time by the __contains__ function.
        */
        return false;
        }

    //#################
    //# End Problem 2 #
    //#################

    def __iter__(self):
        /*
        Perform a forward traversal (in order traversal) starting from 
	    the root of the BST.  This is called a generator function.
        This function is called when a loop	is performed:

        for value in my_bst:
            Console.WriteLine(value);

        */
        yield from self._traverse_forward(self.root)  # Start at the root
        
    def _traverse_forward(self, node):
        /*
        Does a forward traversal (in-order traversal) through the 
        BST.  If the node that we are given (which is the current
        sub-tree) exists, then we will keep traversing on the left
        side (thus getting the smaller numbers first), then we will 
        provide the data in the current node, and finally we will 
        traverse on the right side (thus getting the larger numbers last).

        The use of the 'yield' will allow this function to support loops
        like:

        for value in my_bst:
            Console.WriteLine(value);

        The keyword 'yield' will return the value for the 'for' loop to
	    use.  When the 'for' loop wants to get the next value, the code in
	    this function will start back up where the last 'yield' returned a 
	    value.  The keyword 'yield from' is used when our generator function
        needs to call another function for which a `yield` will be called.  
        In other words, the `yield` is delegated by the generator function
        to another function.

        This function is intended to be called the first time by 
        the __iter__ function.
        */
        if node is not None:
            yield from self._traverse_forward(node.left)
            yield node.data
            yield from self._traverse_forward(node.right)
        
    def __reversed__(self):
        /*
        Perform a formward traversal (in order traversal) starting from 
        the root of the BST.  This function is called when a the 
        reversed function is called and is frequently used with a for
        loop.

        for value in reversed(my_bst):
            Console.WriteLine(value);

        */        
        yield from self._traverse_backward(self.root)  # Start at the root

    //###################
    //# Start Problem 3 #
    //###################
    def _traverse_backward(self, node):
        /*
        Does a backwards traversal (reverse in-order traversal) through the 
        BST.  If the node that we are given (which is the current
        sub-tree) exists, then we will keep traversing on the right
        side (thus getting the larger numbers first), then we will 
        provide the data in the current node, and finally we will 
        traverse on the left side (thus getting the smaller numbers last).

        This function is intended to be called the first time by 
        the __reversed__ function.        
        */
        yield "???"  # Replace this when you implement your solution

    //#################
    //# End Problem 3 #
    //#################

    int get_height(Node from_here) {
        /*
        Determine the height of the BST.  Note that an empty tree
        will have a height of 0 and a tree with one item (root) will
        have a height of 1.
        
        If the tree is empty, then return 0.  Otherwise, call 
        _get_height on the root which will recursively determine the 
        height of the tree.
        */
        if (from_here == null)
            { return 0; }
            else if (from_here == root)
                { return 1; }
                else
                { return get_height(from_here.left)+1;}
            }

    //###################
    //# Start Problem 4 #
    //###################
    def _get_height(self, node):
        /*
        Determine the height of the BST.  The height of a sub-tree 
        (represented by 'node') is 1 plus the height of either the 
        left sub-tree or the right sub-tree (whichever one is bigger).

        This function intended to be called the first time by 
        get_height.
        */
        pass

    //#################
    //# End Problem 4 #
    //#################


# NOTE: Functions below are not part of the BST class above. 

def create_bst_from_sorted_list(sorted_list):
    /*
    Given a sorted list (sorted_list), create a balanced BST.  If 
    the values in the sorted_list were inserted in order from left
    to right into the BST, then it would resemble a linked list (unbalanced). 
    To get a balanced BST, the _insert_middle function is called to 
    find the middle item in the list to add first to the BST.  The 
    _insert_middle function takes the whole list but also takes a 
    range (first to last) to consider.  For the first call, the full 
    range of 0 to len()-1 used.
    """
    bst = BST()  # Create an empty BST to start with 
    _insert_middle(sorted_list, 0, len(sorted_list)-1, bst)
    return bst

###################
# Start Problem 5 #
###################
def _insert_middle(sorted_list, first, last, bst):
    /*
    This function will attempt to insert the item in the middle
    of 'sorted_list' into the 'bst' tree.  The middle is 
    determined by using indicies represented by 'first' and 'last'.
    For example, if the function was called on:

    sorted_list = [10, 20, 30, 40, 50, 60]
    first = 0
    last = 5

    then the value 30 (index 2 which is the middle) would be added 
    to the 'bst' (the insert function above can be used to do this).   

    Subsequent recursive calls are made to insert the middle from the values 
    before 30 and the values after 30.  If done correctly, the order
    in which values are added (which results in a balanced bst) will be:

    30, 10, 20, 50, 40, 60

    This function is intended to be called the first time by 
    create_bst_from_sorted_list.

    The purpose for having the first and last parameters is so that we do 
    not need to create new sublists when we make recursive calls.  Avoid 
    using list slicing to create sublists to solve this problem.

    """
    pass

#################
# End Problem 5 #
#################


# Sample Test Cases (may not be comprehensive) 
Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
tree = BST()
tree.insert(5)
tree.insert(3)
tree.insert(7)
# After implementing 'no duplicates' rule,
# this next insert will have no effect on the tree.
tree.insert(7)  
tree.insert(4)
tree.insert(10)
tree.insert(1)
tree.insert(6)
for x in tree:
    Console.WriteLine(x);  // # 1, 3, 4, 5, 6, 7, 10

Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
Console.WriteLine(3 in tree); // # True
Console.WriteLine(2 in tree); // # False
Console.WriteLine(7 in tree); // # True
Console.WriteLine(6 in tree); // # True
Console.WriteLine(9 in tree); // # False

Console.WriteLine("\n=========== PROBLEM 3 TESTS ===========")
for x in reversed(tree):
    Console.WriteLine(x); //  # 10, 7, 6, 5, 4, 3, 1

Console.WriteLine("\n=========== PROBLEM 4 TESTS ===========")
Console.WriteLine(tree.get_height()); // # 3
tree.insert(6)
Console.WriteLine(tree.get_height()); // # 3
tree.insert(12)
Console.WriteLine(tree.get_height()); // # 4


Console.WriteLine("\n=========== PROBLEM 5 TESTS ===========")
tree1 = create_bst_from_sorted_list([10, 20, 30, 40, 50, 60])
tree2 = create_bst_from_sorted_list([x for x in range(127)]) # 2^7 - 1 nodes
tree3 = create_bst_from_sorted_list([x for x in range(128)]) # 2^7 nodes
tree4 = create_bst_from_sorted_list([42])
tree5 = create_bst_from_sorted_list([])
Console.WriteLine(tree1.get_height()); // # 3
Console.WriteLine(tree2.get_height()); // # 7 .. any higher and its not balanced
Console.WriteLine(tree3.get_height()); // # 8 .. any higher and its not balanced
Console.WriteLine(tree4.get_height()); // # 1
Console.WriteLine(tree5.get_height()); // # 0
*/



    }
    }