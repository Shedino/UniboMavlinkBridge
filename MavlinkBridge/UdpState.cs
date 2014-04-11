using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace MavlinkBridge
{
    class UdpState
    {
        public IPEndPoint e = null;
        public UdpClient u = null;
    }
}
