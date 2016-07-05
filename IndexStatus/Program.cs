using System;
using Microsoft.Search.Interop;

namespace IndexStatus
{
    class Program
    {
        static void Main(string[] args)
        {
            CSearchManager manager = new CSearchManager();
            CSearchCatalogManager catalogManager = manager.GetCatalog(@"SystemIndex");
            _CatalogPausedReason pReason;
            _CatalogStatus pStatus;
            Console.WriteLine(catalogManager.NumberOfItems().ToString());
            int plIncrementalCount;
            int plNotificationQueue;
            int plHighPriorityQueue;
            catalogManager.NumberOfItemsToIndex(out plIncrementalCount, out plNotificationQueue, out plHighPriorityQueue);
            Console.WriteLine(plIncrementalCount.ToString());
            Console.WriteLine(plNotificationQueue.ToString());
            Console.WriteLine(plHighPriorityQueue.ToString());
            catalogManager.GetCatalogStatus(out pStatus, out pReason);
            Console.WriteLine(pStatus.ToString() + " " + pReason.ToString());
            Console.WriteLine(catalogManager.URLBeingIndexed());
            Console.ReadLine();
        }
    }
}
