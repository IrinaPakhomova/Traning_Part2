using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Shop.Workers
{
    class ServiceWorkers: IServiceWorkers
    {
        private List<Worker> workers;
        public ServiceWorkers()
        {
            workers = new List<Worker>();
        } 
     
    }
}
