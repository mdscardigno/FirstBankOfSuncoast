namespace FirstBankOfSuncoast
{
    public class Transaction
    {
        //checking or savings
        public string Account {get; set;}
        //how much
        public int Amount {get; set;}
        //deposit or withdraw
        public string Type {get; set;}
        //Defining a Method or Behavior 
        //
        //Name: Description
        //Input: nothing? We have everything as properties
        //Output: string (containing the description)
        //Work: Combine the properties into a description string 
        //Access: Does the outside world needs to access this? True
        //We want our PROGRAM to be able to call fo a TRANSACTION Description
        //
        //
        public string Description(){
            return Bannerize($"{Type} of ${Amount} to {Account}");
        }
        //Behavior 
        //
        //Name: Bannerize (not bruce/hunk but with stars)
        //Input: string
        //Output: string (with stars)
        //Work: Make a string of stars then the input then more stars
        //Access: Does the outside world need access this? False.
        private string Bannerize(string message){
            return "*************************\n" + message + "*************************\n";
        }
    }
}