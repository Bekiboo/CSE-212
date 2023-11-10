/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Senario: Try to dequeue from an empty queue.
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();

        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and priorities: Bob (2), Tim (5), Sue (3) and
        //           run until the queue is empty or until 10 iterations have been performed.
        // Expected Result: Tim, Sue, Bob, The queue is empty.
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        for (int i = 0; i < 10; i++)
        {
            var person = priorityQueue.Dequeue();
            if (person == null)
                break;
            Console.WriteLine(person);
        }

        // Defect(s) Found: the Dequeue method in the PriorityQueue class is missing a line of code that
        // removes the person from the queue after it is returned.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and priorities: Bob (2), Tim (5), Sue (3),
        //           George (3), Nicholas (5) and run until the queue is empty or until 10 iterations have been performed.
        // Expected Result: Tim, Nicholas, Sue, George, Bob, The queue is empty.
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("George", 3);
        priorityQueue.Enqueue("Nicholas", 5);

        for (int i = 0; i < 10; i++)
        {
            var person = priorityQueue.Dequeue();
            if (person == null)
                break;
            Console.WriteLine(person);
        }

        // Defect(s) Found: The for-loop in the Dequeue method in the PriorityQueue class wasn't checking
        // the last element in the queue.  It should be <= instead of <.
        // Also, the comparison in the if-statement in that same method was returning the wrong person.
        // It should be > instead of >=.

        Console.WriteLine("---------");
    }
}