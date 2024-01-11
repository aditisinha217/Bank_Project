namespace BankProject;

class SBAccount{

    public SBAccount(){

    }
    public SBAccount(int AccountNumber, string? CustomerName, string? CustomerAddress, decimal CurrentBalance){
        this.AccountNumber=AccountNumber;
        this.CurrentBalance=CurrentBalance;
        this.CustomerAddress=CustomerAddress;
        this.CustomerName=CustomerName;
    }
    public int AccountNumber{
        get;
        set;
    }

    public string? CustomerName{
        get;
        set;
    }

    public string? CustomerAddress{
        get;
        set;
    }

    public decimal CurrentBalance{
        get;
        set;
    }
}

class SBTransaction{
    public SBTransaction(){

    }

    public SBTransaction(int AccountNumber, decimal Amount, int TransactionId, string? TransactionType, DateTime TransactionDate){
        this.AccountNumber=AccountNumber;
        this.Amount=Amount;
        this.TransactionId=TransactionId;
        this.TransactionType=TransactionType;
        this.TransactionDate=TransactionDate;
    }
    public int TransactionId{
        get;
        set;
    }

    public DateTime TransactionDate{
        get;
        set;
    }

    public int AccountNumber{
        get;
        set;
    }

    public decimal Amount{
        get;
        set;
    }

    public string? TransactionType{
        get;
        set;
    }
}