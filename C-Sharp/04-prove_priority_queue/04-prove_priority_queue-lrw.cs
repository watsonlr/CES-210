/********
CSE212 
(c) BYU-Idaho
04-Prove - Problem 2

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
using System.Collections.Generic;
using System;
using System.Linq;
myQueue thePriorityQueue = new myQueue();

Console.WriteLine("CSE212:  04-Prove - Problem 2");  // Comment out this line


    // 
    //     This queue follows the same FIFO process except that higher priority
    //     nodes will be dequeued before lower priority nodes.  Nodes of the same
    //     priority will follow the same FIFO process.
    //     

/*
The Queue is made from an array of Node Objects
*/

Console.WriteLine("Test 1");
thePriorityQueue.EnQueue("Object 1",1);

Console.WriteLine("after enque[0]: " + thePriorityQueue.Peek(0).value);
// Console.WriteLine("DeQueing is: " + thePriorityQueue.DeQueue());


class myQueue {
    //public static List<Node> Queue();  // only need one queue.  The class should be called only once tho
    //  List<Node> Queue = new List<Node>();
    public static List<Node> theQueue = new List<Node>();
     // Queue is a list of Nodes

    public void EnQueue(object v,int pri) {
        // var adding_node = new Node
        Node node_to_add = new Node(v,pri);
        // Console.WriteLine("Node_to_add value:  " + node_to_add.value);
        // Console.WriteLine("Node_to_add priority:  " + node_to_add.priority);
        // Console.WriteLine("Enqueueing:  " + node_to_add.ToString());
        theQueue.Add(node_to_add);
        }

    public Node Peek(int element) {
        return theQueue[element];
        }
    
    public Node DeQueue_with_priority() {

        /* This routine goes thru all the list and finds the highest priority
           The index of the highest priority is stored, and then that Node is returned and
           taken off the Queue
        */

        }



    public Node DeQueue(int to_dequeue) {
        // var adding_node = new Node
        Node node_to_dequeue = theQueue[to_dequeue];
        theQueue.RemoveAt(to_dequeue);
        return node_to_dequeue;
        }

    }

class Node {
    public object value = new object();    // Store anything as a value
    public int priority;                   // Priority is a number
    public Node(object val_in,int pri_in) {
        Console.WriteLine("Node Created value:" + val_in + " Priority: " + pri_in);
        value = val_in;
        priority = pri_in;  // Set the initial priority to 0
    }

}


