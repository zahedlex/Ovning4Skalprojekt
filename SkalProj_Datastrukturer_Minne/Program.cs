using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {   
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            while(true)
            { 
             
            List<string> theList = new List<string>();
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

            switch(nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine("Count is : " + theList.Count);                           //Svar på frågor
                        Console.WriteLine(" Capacity is : " + theList.Capacity);                    //Count är alltid lägre än Capacity.
                                                                                                    //Medans element läggs på tills Count överstiger Capacity då förändras och ökar Capacity.
                        break;                                                                      //Capacity är antalet element som listan kan lagra medans count är det befintliga antalet element i listan.
                        case '-':                                                                   
                        theList.Remove(value);
                        Console.WriteLine("Count is : " + theList.Count);
                        Console.WriteLine(" Capacity is : " + theList.Capacity);
                        break;

                        case '0':
                        Environment.Exit(0);
                        Main();
                        break;

                    default:
                    Console.WriteLine("Plese enter som valid input + or -");
                    break;
                    }
            }
            }

                    
      
                
        

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
           
            while(true){
                
                Queue my_queue = new Queue();
            
                switch(my_queue)
            {
                case 1:
                    my_queue.Enqueue();
                    foreach (var item in my_queue)
                        Console.WriteLine(item);
                    break;

                    case 2:
                    my_queue.Dequeue();
                    foreach (var item in my_queue)
                        Console.WriteLine(item);
                    break;

                    case '0':
                        Environment.Exit(0);
                        Main();
                        break;

                    default:
                    Console.WriteLine("Plese enter name to queue");
                    break;

                    if(!my_queue.IsEmpty())
                    case 1: ("Kalle", "Greta");
                    case 2:"Kalle";
                    case 1:"Stina";
                    case 2: "Greta";
                    case 1: "Olle";
                    
                    }


            }
            

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            while(true)
            {
                Stack my_stack = new Stack();

                switch (my_stack)
                {
                    case 1: my_stack.Push();
                        foreach (var item in my_stack)
                            Console.WriteLine(item);
                        break;

                        case 2: my_stack.Pop();
                        foreach (var item in my_stack)
                            Console.WriteLine(item);
                        break;

                        case 0:
                        Environment.Exit(0);
                        Main();
                        break ;

                        default:
                        Console.WriteLine("Plese enter name to stack");
                        break ;

                        if(!my_stack.IsEmpty())

                            case 1: ("Kalle", "Greta");
                            case 2:"Kalle";
                            case 1:"Stina";
                            case 2: "Greta";
                            case 1: "Olle";
                }
            }
        }

        static void ReverseText(string str)
        {
                     
                        for(int i = 0; i < str.Length; ++i)
                        {
                            if(str[i] != ' ')
                            {
                                my_stack.Push(str[i]);
                            }
                            else
                            {
                                while(my_stack.Count > 0)
                                    Console.WriteLine(my_stack.Pop());
                            }
                            Console.Write(" ");
                        }

                        while(my_stack.Count > 0)
                        {
                            Console.WriteLine(my_stack.Pop());
                        }
        }

         
        
        static Boolean isMatchingPair(char character1, char character2)
            { 
            

            if(character1 == '(' && character2 == ')')
                return true;
            else if(character1 == '{' && character2 == '}')
                return true;
             else if(character1 == '[' && character2 == ']')
                return true;
            else return false;
            }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

           

            char[] exp;

            Stack<char> st = new Stack<char>();

            //Traverse the given expresssion to check matching bracket
            for(int i = 0; i < exp.Length; i++)
            {
                //if the exp[i] is a starting bracket then pusch it
                if(exp[i] == '{' || exp[i] == ')' || exp[i] == ']')
                    st.Push(exp[i]);

                //if exp[i] is an ending bracket
                //then pop from stack and check if the
                // popped bracket is a matching pair
                if(exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    //if we see an ending bracket withot a pair then return false
                    if(st.Count == 0)
                    { return false;}

                    //Pop the top element from stack, if it is not a pair
                    //brckets of character then there is a mismatch.
                    else if(!isMatchingPair(st.Pop(), exp[i]))
                    {
                        return false;
                    }
                  }           
                }
            

        //if there is something left in expression then thereis a starting bracket without
        //a closing bracket
        if(st.Count == 0)
            return true; //balances

            else{
            return false; // not balances
           
           
            }
        }
        
        
    }
}


        
       
    
    
