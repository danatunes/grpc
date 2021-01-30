using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatProject.Protos;

namespace ChatProject
{

    public class ChatService : Protos.Chat.ChatBase
    {
        private readonly ChatRoom _chatroomService;

        public ChatService(ChatRoom chatRoomService)
        {
            _chatroomService = chatRoomService;
        }

        public override async Task join(IAsyncStreamReader<Message> requestStream, IServerStreamWriter<Message> responseStream, ServerCallContext context)
        {
            if (!await requestStream.MoveNext()) return;

            do
            {
                _chatroomService.Join(requestStream.Current.User, responseStream);
                await _chatroomService.BroadcastMessageAsync(requestStream.Current);
            } while (await requestStream.MoveNext());

            _chatroomService.Remove(context.Peer);

        }


    }
}
