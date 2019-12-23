using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class TestHub : Hub
{
    public async Task ReceiveMessage(int v)
    {
        await Clients.All.SendAsync("ReceiveMessage", v);
    }

    public override Task OnConnectedAsync()
    {
        Console.WriteLine("Connected");
        return base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception e)
    {
        Console.WriteLine($"Disconnected {e?.Message}");
        await base.OnDisconnectedAsync(e);
    }
}
