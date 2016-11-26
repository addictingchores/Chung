using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace AddictingChoresProject.Hubs
{
    public class TestHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}