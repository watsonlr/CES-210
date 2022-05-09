/********
CSE212 
(c) BYU-Idaho
04-Teach - Problem 1 - Solution

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
using System.Collections.Generic;
Console.WriteLine("CSE212:  04-Teach - Problem 1 - Solution");  // Comment out this line

    
public class Simple_Queue {
    
    public Simple_Queue() {
        this.queue = new List<object>();
    }
    // 
    //         Enqueue the value provided into the queue
    //         
    public virtual object enqueue(object value) {
        this.queue.insert(0, value);
    }
    // 
    //         Dequeue the next value and return it
    //         
    public virtual object dequeue() {
        if (this.queue.Count <= 0) {
            throw IndexError();
        }
        var value = this.queue[1];
        this.queue.Remove(1);
        return value;
    }
}

public static object queue = Simple_Queue();

static Module() {
        queue.enqueue(100);
        queue.enqueue(200);
        queue.enqueue(300);
        queue.enqueue(400);
        queue.dequeue();
    }

public static object value = queue.dequeue();
public static object queue = Simple_Queue();
public static object value = queue.dequeue();
public static object value = queue.dequeue();
public static object value = queue.dequeue();
public static object queue = Simple_Queue();


/********** Test Cases  **************/
// Test 1
// Scenario: Enqueue one value and then Dequeue it.
// Exepcted Result: It should display 100
Console.WriteLine("Test 1");
queue = Simple_Queue();
queue.enqueue(100);
value = queue.dequeue();
Console.WriteLine(value);
// Defect(s) Found:
Console.WriteLine("=================");

// Test 2
// Scenario: Enqueue multiple values and then Dequeue all of them
// Exepcted Result: It should display 200, then 300, then 400 in that order
Console.WriteLine("Test 2");
queue = Simple_Queue();
queue.enqueue(200);
queue.enqueue(300);
queue.enqueue(400);
value = queue.dequeue();
Console.WriteLine(value);
value = queue.dequeue();
Console.WriteLine(value);
value = queue.dequeue();
Console.WriteLine(value);
// Defect(s) Found: 
Console.WriteLine("=================");

// Test 3
// Scenario: Dequeue from an empty Queue
// Exepcted Result: An exception should be raised
Console.WriteLine("Test 3");
queue = Simple_Queue();
try:
    queue.dequeue();
    Console.WriteLine("Oops ... This shouldn't have worked.");
except IndexError:
    Console.WriteLine("I got the exception as expected.");
// Defect(s) Found: 