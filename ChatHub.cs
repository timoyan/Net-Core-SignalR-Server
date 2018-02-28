  using Microsoft.AspNetCore.SignalR;

  namespace Net_Core_SignalR_Server {
      public class ChatHub : Hub {
          public void SendToAll (string name, string message) {
              Clients.All.InvokeAsync ("sendToAll", name, message);
          }
      }
  }