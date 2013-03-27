using Microsoft.AspNet.SignalR;
public class Multi : Hub
{
    public void Send(string message)
    {
        // Call the addMessage method on all clients            
        //Clients.All.fAvisoReceber(message);
        Clients.Others.fAvisoReceber(message);
    }
}