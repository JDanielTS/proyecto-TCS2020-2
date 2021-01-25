using ServicioMemorama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServidorMemorama
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServicioClienteMemorama));
            host.Open();
            Console.WriteLine("Servicio iniciado...");
            Console.ReadLine();
        }
    }
}
