using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.SignalR;
using DataAccess.Entities;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChatRoomMVC.Connection
{
    public class ChatConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            Data chatData = new Data() { Name = "Server: ", Message = "User " + connectionId + " has connected" };


            //chatData.Message;
            //chatData.Name;

            chatData.Attribute = "ConnectionInfo";
            return Connection.Broadcast(chatData);
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            Data chatData = JsonConvert.DeserializeObject<Data>(data);
            chatData.Attribute = "OnReceived";
            return Connection.Broadcast(chatData);
        }

        protected override Task OnDisconnected(IRequest request, string connectionId, bool stopCalled)
        {
            Data chatData = new Data() { Name = "Server: ", Message = "User " + connectionId + " has disconnected" };
            chatData.Attribute = "ConnectionInfo";
            return Connection.Broadcast(chatData);
        }
    }
}   