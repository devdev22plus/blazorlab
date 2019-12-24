using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Protocol;

public class TestHub : Hub
{
    public async Task ReceiveMessage(int v)
    {
        await Clients.All.SendAsync("ReceiveMessage", v);
    }
}
