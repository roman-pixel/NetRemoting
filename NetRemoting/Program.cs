using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace NetRemoting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpCann = new TcpChannel(11000);
            ChannelServices.RegisterChannel(tcpCann, false);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Server_obj.ServerObj), "met1", WellKnownObjectMode.SingleCall);

            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Udal_obj.Udal_obj), "met2", WellKnownObjectMode.SingleCall);

            Console.WriteLine("Ожидание подключения...");
            Console.ReadLine();
        }
    }
}
