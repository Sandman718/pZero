using SignUp;
using System.Collections.Generic;

bool exit = false;
//creating a dynamic list
List<SignUpCustomer> customerList = new List<SignUpCustomer>();

do{

    Console.WriteLine("Welcome the Game Store Galore ");
    Console.WriteLine("Make a selection");
    Console.WriteLine("1 - Sign up");
    Console.WriteLine("2 - Log in");
    Console.WriteLine("3 - Inventory");
    Console.WriteLine("4 - Cart");
    Console.WriteLine("x - Exit");

    //variable to store user input for our switch
    string userInput = Console.ReadLine();
  

    switch (userInput) {

        case "1":
            Console.WriteLine("What is your name: ");
            Console.WriteLine(" ");
            //taking the user input and saving it as string var named newNote
            string name = Console.ReadLine();

            //new customer being created
            SignUpCustomer newCustomer = new SignUpCustomer();
            newCustomer.name = name;

            customerList.Add(newCustomer);
            Console.WriteLine($"Customer Name: {name} ");
        
           
            Console.WriteLine(newCustomer.printCust());
        break;

        case "2":
            Console.WriteLine("put in your credentials");
        break;

        case "3":
            Console.WriteLine("Inventory");
            //foreach loop loops through items in a collection
            foreach(SignUpCustomer item in customerList)
            {
                Console.WriteLine(item.printCust());
            }
           
        break;

        case "4":
            Console.WriteLine("your cart");
            break;

        case "x":
            Console.WriteLine("See you next time");
            exit = true;
        break;

        default:
            Console.WriteLine("Try again ");
        break;

    }//end switch
}while (!exit);//end while
