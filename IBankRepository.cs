namespace BankProject;

interface IBankRepository{
    public void NewAccount(SBAccount acc);
    List<SBAccount> GetAllAccounts();
    SBAccount GetAccountDetails(int accno);
    public void DepositAmount(int accno, decimal amt);
    public void WithdrawAmount(int accno, decimal amt);
    List<SBTransaction> GetTransactions(int accno);
}