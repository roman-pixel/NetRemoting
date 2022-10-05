using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpChannel tcpCanC = new TcpChannel();
            ChannelServices.RegisterChannel(tcpCanC, false);

            Server_obj.ServerObj obj1=(Server_obj.ServerObj)Activator.GetObject(typeof(Server_obj.ServerObj),
                "tcp://localhost:11000/met1");
            tcpCanC.StopListening(obj1);
            Udal_obj.Udal_obj obj2= (Udal_obj.Udal_obj)Activator.GetObject(typeof(Udal_obj.Udal_obj),
                "tcp://localhost:11000/met2");
            tcpCanC.StartListening(obj2);
            Console.WriteLine($"Результат вычислений: {obj1.ServerMethod(5, 4)}");
            Console.WriteLine(obj2.Hello());
            Console.WriteLine("Введите имя\n");
            Console.WriteLine(obj2.Greeting(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
