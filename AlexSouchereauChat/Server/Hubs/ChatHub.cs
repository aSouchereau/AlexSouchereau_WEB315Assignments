using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }

        public async Task SendTypeIndicator(string name)
        {
            await Clients.All.SendAsync("ReceiveTypeIndicator", name);
        }
        public async Task SendRemoveTypeIndicator(string name)
        {
            await Clients.All.SendAsync("ReceiveRemoveTypeIndicator", name);
        }
    }
}