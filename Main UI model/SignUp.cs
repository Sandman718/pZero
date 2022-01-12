namespace SignUp;

//class
public class SignUpCustomer{

//constructor
    public SignUpCustomer() {}

//attributes
    public string name { get; set; }
    public string state { get; set; }

    public int age {get; set;}
    public int customerNum { get; set; }

    //set the name of the customer
    public void setName() {
        string name = "";
        this.name = name;

    }

    public void setState() {
        string state = "";
        this.state = state;

    }

    public int setAge(int age) {
        
        
        return age;
    }

    //set a number to the customer
    public int setCustomerNum(int i) {
        //int i = 0;
        i++;
       return i;
    }

    //print attribute values of the class
    public string printCust() {
        return $"Name : {this.name}  State : {this.state} Age: {age}";
    }





}