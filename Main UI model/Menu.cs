namespace Menu;
using SignUp;
using DL;


public class MenuType {
//variables

public void doStuff () {
bool exit = false;

do{

    Console.WriteLine("Welcome the Game Store Galore ");
    Console.WriteLine("Make a selection");
    Console.WriteLine("1 - Sign up");
    Console.WriteLine("2 - Log in");
    Console.WriteLine("3 - Customer List");
    Console.WriteLine("4 - Cart");
    Console.WriteLine("x - Exit");

    //variable to store user input for our switch
    string userInput = Console.ReadLine();
  

    switch (userInput) {

        case "1":
            //maybe refactor with object initializer....down the road
            //taking the user input and saving into a variable for new created customers
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("What is your state: ");
            string state = Console.ReadLine();

            Console.WriteLine("What is your age: ");
            string stringAge = Console.ReadLine();
            int age = 0;
            age = int.Parse(stringAge);
            int i=0;

            //new customer being created
            SignUpCustomer newCustomer = new SignUpCustomer();
            newCustomer.name = name;
            newCustomer.state = state;
            newCustomer.age = age;
            newCustomer.setCustomerNum(i);

            //add new customer to list
            Storage.customerList.Add(newCustomer);
            Console.WriteLine($"Customer Name: {name} ");
            Console.WriteLine(newCustomer.printCust());
        break;

        case "2":
            Console.WriteLine("put in your credentials");
        break;

        case "3":
            Console.WriteLine("Inventory");
            //foreach iterates through the list 
            foreach(SignUpCustomer item in Storage.customerList)
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
}//end method
}