namespace FirstBankOfSuncoast
{
    public class Transaction
    {
        //checking or savings
        public string Account {get; set;}
        //how much
        public int Amount {get; set;}
        //deposit or withdraw
        public string Action {get; set;}
    }
}