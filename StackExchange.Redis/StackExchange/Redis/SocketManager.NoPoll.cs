﻿#if !FEATURE_SOCKET_MODE_POLL
namespace StackExchange.Redis
{
    public partial class SocketManager
    {
        internal static readonly SocketMode DefaultSocketMode = SocketMode.Async;

        private void OnAddRead(System.Net.Sockets.Socket socket, ISocketCallback callback)
        {
            throw new System.NotSupportedException();
        }
    }
}
#endif