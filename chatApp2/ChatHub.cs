using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Log message to console
            Console.WriteLine($"Received message from {user}: {message}");

            // Send message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("ReceiveMessage", "Welcome to the chat!");
            await base.OnConnectedAsync();
        }
    }
}
