namespace PlayTogether.Web.Services;
public class Login_service
{
    public int Login_tries { get; private set; }
    public int Login_tries_worked { get; private set; }
    
    public string loglog { get; private set; }
    
    DateTime jetzt = DateTime.Now;
    
    public void FalseTry()
    {
        Login_tries++;
        loglog = loglog + "unsucessfull login try at " + jetzt + '\n';
        Console.WriteLine(loglog);
    }

    public void RightTry()
    {
        Login_tries_worked++;
        loglog = loglog + "sucessfull login try at " + jetzt + '\n';
        Console.WriteLine(loglog);
    }
    
    

}