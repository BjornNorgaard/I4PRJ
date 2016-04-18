﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Smartpool.Connection.Model
{
    class ClientResponseManager
    {
        public Message DeserializeString(string messageString)
        {
            var receivedMessage = JsonConvert.DeserializeObject<Message>(messageString);

            switch (receivedMessage.MsgType)
            {
                case MessageTypes.LoginResponse:
                    return JsonConvert.DeserializeObject<LoginResponseMsg>(messageString);
                case MessageTypes.AddPoolResponse:
                    return JsonConvert.DeserializeObject<AddPoolResponseMsg>(messageString);
                case MessageTypes.AddUserResponse:
                    return JsonConvert.DeserializeObject<AddUserResponseMsg>(messageString);
                default:
                    if (receivedMessage.MessageInfo != null)
                        return new Message(receivedMessage.MessageInfo);
                    else
                    {
                        return new Message("An unknown error occured");
                    }
            }
        }
    }
}