/********
CSE212 
(c) BYU-Idaho
04-Teach - Problem 2 - Solution

It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
to post it online.  Storage into a personal and private repository (e.g. private
GitHub repository, unshared Google Drive folder) is acceptable.

//--- Created from: dotnet new console. See https://aka.ms/new-console-template for more information ---//
********/
Console.WriteLine("CSE212:  04-Teach - Problem 2 - Solution");  // Comment out this line


public class customerService{
    
    public class customerServiceQueue {
        public List<Customer> theQueue = new List<Customer>();
        // 
        public void EnQueue(Customer to_add) {
            //         Add an item to the queue
            // Console.WriteLine("Node_to_add priority:  " + node_to_add.priority);
            // Console.WriteLine("Enqueueing:  " + node_to_add.ToString());
            theQueue.Add(to_add);
            }

        public Customer DeQueue() {
            Customer empty = new Customer("Empty",-1);
            if (theQueue.Count == 0) {
                Console.WriteLine("Queue EMPTY");
                return empty;
                }
            Customer toreturn = theQueue[0];
            // Remove the next item from the queue. 
            theQueue.RemoveAt(0);
            return toreturn;
            }
        public bool is_empty() {
            return (theQueue.Count == 0);
            }
        public void printWholeQueue(){
            Console.WriteLine("\t\tQueue Count is:  " +theQueue.Count);
            for(int i=0;i<theQueue.Count; i++) {
                Console.WriteLine("\t\t[" + i + "]\t" + theQueue[i].name + "\t turns:\t" + theQueue[i].turns);
            }
        }
        public int Count() {
            return theQueue.Count;
            }
    public class Customer {
        public int accountID; 
        public string name = "";
        public string problem = ""; 
        name = Console.ReadLine();
        }
    }