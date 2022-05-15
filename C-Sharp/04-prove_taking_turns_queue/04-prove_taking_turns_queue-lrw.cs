/********
CSE212 
(c) BYU-Idaho
04-Prove - Problem 1

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online. Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
using System.Collections.Generic;
using System;

Console.WriteLine("CSE212:  04-Prove - Problem 1");  // Comment out this line

Queue theTurnsQueue = new turnsQueue();

//     
public class Queue {
    public List<Person> theQueue = new List<Person>();

    // 
    //         Add an item to the queue
    //         
    public void EnQueue(Person to_add) {
    // var adding_node = new Node
    // Console.WriteLine("Node_to_add priority:  " + node_to_add.priority);
    // Console.WriteLine("Enqueueing:  " + node_to_add.ToString());
        theQueue.Add(to_add);
        }
// 
//         Remove the next item from the queue. 
//         
    public object dequeue() {
        var value = this.queue[0];
        this.queue.Remove(0);
        return value;
    }
    // 
    //         Check to see if the queue is empty.
    //         
    public bool is_empty() {
        return (theQueue.Count == 0);
        }
    // 
    //         Support the len() function
    //         
    public int Count() {
        return theQueue.Count;
    }
}

public class turnsQueue(){
    // 
    //     This queue is circular.  When people are added via add_person, then they are added to the 
    //     back of the queue (per FIFO rules).  When get_next_person is called, the next person
    //     in the queue is displayed and then they are placed back into the back of the queue.  Thus,
    //     each person stays in the queue and is given turns.  When a person is added to the queue, 
    //     a turns parameter is provided to identify how many turns they will be given.  If the turns is 0 or
    //     less than they will stay in the queue forever.  If a person is out of turns then they will 
    //     not be added back into the queue.
    //     
    // has specialized add/delete instruction that make this circular


    }







public class Person {
//         A person is defined with a name and a number of turns.
    public string name; 
    public int turns; 

    public Person(string name_in, int turns_in) {
        name = name_in;
        turns = turns_in;
    }
    public void showMe(){
        Console.WriteLine("Name: "+ name + " Turns: " + turns);
        }
    // 
    //             Support the display of single person.
    //             
}

// 
//         Add new people to the queue with a name and number of turns
//         
public virtual object add_person(object name, object turns) {
    var person = Taking_Turns_Queue.Person(name, turns);
    this.people.enqueue(person);
}
// 
//         Get the next person in the queue and display them.  The person should
//         go to the back of the queue again unless the turns variable shows that they 
//         have no more turns left.  Note that a turns value of 0 or less means the 
//         person has an infinite number of turns.  An error message is displayed 
//         if the queue is empty.
//         
public virtual object get_next_person() {
    if (this.people.is_empty()) {
        Console.WriteLine("No one in the queue.");
    } else {
        var person = this.people.dequeue();
        if (person.turns > 1) {
            person.turns -= 1;
            this.people.enqueue(person);
        }
        Console.WriteLine(person.name);
    }
}

// 
//         Support the len() function
//         
public virtual object @__len__() {
    return this.people.Count;
}

// 
//         Provide a string representation of everyone in the queue
//         
public override object ToString() {
    return this.people.ToString();
}

public static object theTurnsQueue = Taking_Turns_Queue();

testing() {
    theTurnsQueue.add_person("Bob", 2);
    theTurnsQueue.add_person("Tim", 5);
    theTurnsQueue.add_person("Sue", 3);
    theTurnsQueue.get_next_person();
    theTurnsQueue.add_person("Bob", 2);
    theTurnsQueue.add_person("Tim", 5);
    theTurnsQueue.add_person("Sue", 3);
    theTurnsQueue.get_next_person();
    theTurnsQueue.add_person("George", 3);
    theTurnsQueue.get_next_person();
    theTurnsQueue.add_person("Bob", 2);
    theTurnsQueue.add_person("Tim", 0);
    theTurnsQueue.add_person("Sue", 3);
    theTurnsQueue.get_next_person();
    theTurnsQueue.get_next_person();
}

}