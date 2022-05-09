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

public class Priority_Queue {
    
    // 
    //         Each node is the queue will have both a value and a priority.
    //         
    public class Node {
        
        public Node(object value, object priority) {
            this.value = value;
            this.priority = priority;
        }
        
        // 
        //             Display a single node
        //             
        public override object ToString() {
            return "{} (Pri:{})".format(this.value, this.priority);
        }
    }
    
    public Priority_Queue() {
        this.queue = new List<object>();
    }
    
    // 
    //         Add a new value to the queue with an associated priority.  The
    //         node is always added to the back of the queue irregardless of 
    //         the priority.
    //         
    public virtual object enqueue(object value, object priority) {
        var new_node = Priority_Queue.Node(priority, value);
        this.queue.append(new_node);
    }
    
    // 
    //         Remove the next value from the queue based on the priority.  The 
    //         highest priority item will be removed.  In the case of multiple
    //         values with the same high priority, the one closest to the front
    //         (in traditional FIFO order) will be removed.  Priority values are
    //         interpreted as higher numbers have higher priority.  For example, 
    //         10 is a higher priority than 5.
    //         
    public virtual object dequeue() {
        if (this.queue.Count == 0) {
            // Verify the queue is not empty
            Console.WriteLine("The queue is empty.");
            return null;
        }
        // Find the index of the item with the highest priority to remove
        var high_pri_index = 0;
        foreach (var index in Enumerable.Range(1, this.queue.Count - 1)) {
            if (this.queue[index].priority >= this.queue[high_pri_index].priority) {
                high_pri_index = index;
            }
        }
        // Remove and return the item with the highest priority
        var value = this.queue[high_pri_index].value;
        return value;
    }
    
    // 
    //         Support the len() function
    //         
    public virtual object @__len__() {
        return this.queue.Count;
    }
    
    //  
    //         Suppport the str() function to provide a string representation of the
    //         priority queue.  This is useful for debugging.  If you have a 
    //         Priority_Queue object called pq, then you run print(pq) to see the 
    //         contents.
    //         
    public override object ToString() {
        var result = "[";
        foreach (var node in this.queue) {
            result += node.ToString();
            result += ", ";
        }
        result += "]";
        return result;
    }
}