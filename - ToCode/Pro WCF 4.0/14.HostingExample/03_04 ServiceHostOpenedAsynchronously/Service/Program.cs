﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wrox.CarRentalService.Implementations.Europe;
using System.ServiceModel;
using System.ServiceModel.Description;
using Wrox.CarRentalService.Contracts;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri[] baseAddresses = new Uri[]
            {
                new Uri("http://localhost:10101/CarRentalService"),
                new Uri("net.tcp://localhost:10102/CarRentalService")
            };

            ServiceHost host = new ServiceHost(typeof(CarRentalService), baseAddresses);
            host.AddDefaultEndpoints();
            try
            {
                IAsyncResult result = host.BeginOpen(new AsyncCallback(ServiceHostOpenCallback), host);

                Console.WriteLine("Waiting...");
                result.AsyncWaitHandle.WaitOne();
                Console.WriteLine("Host Opened...");
                Console.ReadLine();

                host.Close();
            }
            catch (CommunicationException ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
            catch (TimeoutException ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
        }

        public static void ServiceHostOpenCallback(IAsyncResult result)
        {
            ServiceHost host = result.AsyncState as ServiceHost;

            Console.WriteLine("The car rental service is up and listening on the endpoints:");
            foreach (var endpoint in host.Description.Endpoints)
            {
                Console.WriteLine("\t" + endpoint.Address.Uri.ToString());
            }
        }
    }
}