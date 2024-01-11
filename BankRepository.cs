
namespace BankProject;

class BankRepository : IBankRepository
{
    int count=0;
    List<SBAccount> sBAccounts=new List<SBAccount>();
    List<SBTransaction> sBTransactions=new List<SBTransaction>();
    public void NewAccount(SBAccount acc)
    {
        sBAccounts.Add(new SBAccount(acc.AccountNumber, acc.CustomerName, acc.CustomerAddress, acc.CurrentBalance));
    }

    public SBAccount GetAccountDetails(int accno)
    {
        //BY looping
        foreach (SBAccount item in sBAccounts)
        {
            if(item.AccountNumber==accno){
                return item;
            }
        }
        return new SBAccount();
    }

    public void DepositAmount(int accno, decimal amt)
    {
        count++;
        System.Console.WriteLine("Enter your transaction type: \n 1. Deposit \n 2. Withdraw ");
        string? tr= Console.ReadLine();
        foreach (SBAccount item in sBAccounts)
        {
            if(accno==item.AccountNumber){
                item.CurrentBalance+=item.AccountNumber;
            }
        }

        sBTransactions.Add(new SBTransaction(accno, amt, count, tr, DateTime.Now));
    }

    public void WithdrawAmount(int accno, decimal amt)
    {
        count++;
        System.Console.WriteLine("Enter your transaction type: \n 1. Deposit \n 2. Withdraw ");
        string? tr= Console.ReadLine();
        foreach (SBAccount item in sBAccounts)
        {
            if(accno==item.AccountNumber){
                item.CurrentBalance-=item.AccountNumber;
            }
        }

        sBTransactions.Add(new SBTransaction(accno, amt, count, tr, DateTime.Now));
    }

    public List<SBTransaction> GetTransactions(int accno)
    {
        List<SBTransaction> l=new List<SBTransaction>();
        foreach(SBTransaction i in sBTransactions){
            if(accno==i.AccountNumber){
                l.Add(i);
            }
        }
        return l;
    }


    public List<SBAccount> GetAllAccounts()
    {
        throw new NotImplementedException();
    }
}