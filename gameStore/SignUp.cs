namespace SignUp;

//class
public class SignUpCustomer{

//constructor
    public SignUpCustomer() {}

    public string name { get; set;}
    public int customerNum {get; set;}

    //set the name to the customer
    public void setName() {
        string name = "";
        this.name = name;

    }

    //set a number to the customer
    public void setCustomerNum() {
        int i = 0;
        i++;
        this.customerNum = i;
    }

    //print attributes values of the class
    public string printCust() {
        return $"Name is: {this.name} Customer Number: {this.customerNum}";
    }





}