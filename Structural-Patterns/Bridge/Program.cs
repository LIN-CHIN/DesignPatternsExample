using Bridge.Device;
using Bridge.Remote;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            RemoteAbstract remote = new BaseRemote(tv);

            Console.WriteLine("ori:");
            Console.WriteLine(remote.GetVolumn());

            Console.WriteLine("+10 after");
            remote.SetVolumnUp(10);
            Console.WriteLine(remote.GetVolumn());

            Console.WriteLine("-5 after");
            remote.SetVolumnDown(5);
            Console.WriteLine(remote.GetVolumn());

        }
    }
}
