using System;
using NetHpServerLinux.model;
using NetHpServerLinux.model;

namespace NetHpServerLinux
{
    /// <summary>
    /// 负责对收到的字节流 组成完成的包
    /// </summary>
    internal class ClientPacketManage
    {
        private NetServer _netServer;

        public ClientPacketManage(NetServer netServer)
        {
            _netServer = netServer;
        }

        public Action<SocketEventParam> OnSocketPacketEvent { get; internal set; }

        public void PutSocketParam(SocketEventParam param)
        {
            throw new NotImplementedException();
        }
    }
}