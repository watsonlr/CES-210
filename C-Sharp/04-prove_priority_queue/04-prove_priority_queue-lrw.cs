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
Console.WriteLine("CSE212:  04-Prove - Problem 2");  // Comment out this line


    // 
    //     This queue follows the same FIFO process except that higher priority
    //     nodes will be dequeued before lower priority nodes.  Nodes of the same
    //     priority will follow the same FIFO process.
    //     
class myQueue {
    //public static List<Node> Queue();  // only need one queue.  The class should be called only once tho
    //  List<Node> Queue = new List<Node>();
     private Queue<Node> theQueue = new Queue<Node>();
    
    class Node {
        private object value = new object();    // Store anything as a value
        private int priority;                   // Priority is a number
        public Node(object val_in,int pri_in) {
            Console.WriteLine("Node Created value:" + val_in);
            value = val_in;
            priority = pri_in;  // Set the initial priority to 0
        }
    public void EnQueue(object v,int pri) {
        // var adding_node = new Node
        Node node_to_add = new Node(v,pri);
        theQueue.Add(node_to_add);
        }
    }


} 