namespace BankProject;

class BankProjectClient{
    public static void Main(){
        SBAccount s=new SBAccount();
        BankRepository b=new BankRepository();
        System.Console.WriteLine("The menu is: \n 1. Create new account \n 2. Get account details \n 3. Deposit Amount \n 4. Withdraw ammount \n 5. Get transaction details.");
        System.Console.WriteLine("Enter the options from above menu: ");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1: SBAccount s1=new SBAccount(1, "Aditi", "Jbp", 12334994); b.NewAccount(s1); 
                    System.Console.WriteLine("Account has been created");
                    break;
            case 2: // so likewise all functions can be implemented
            default: break;
        }
    }
}