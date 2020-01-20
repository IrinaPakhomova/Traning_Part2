using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Shop.Workers
{
    interface IServiceWorkers
    {
        void addNewWorker(Worker worker);
        bool existWorker(Worker worker);
        bool deleteWorkere(Worker worker);
        List<Worker> getListOfWorker();
    }
}
