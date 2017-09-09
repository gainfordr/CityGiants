using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *****************************************************************************
// Author: Ryan Gainford
// Created: September 4, 2017 
// Updated: September 4, 2017
//
// Description: Creates a pool of workers on start up to be taken from when new  
// workers are bought. 
//
// *****************************************************************************

public class WorkerManager : MonoBehaviour
{

    #region Member Variables

    List<Worker> ListOfWorkers;

    const int iWORKERPOOLSIZE = 20; 

    #endregion

    public WorkerManager()
    {

        // Intiailize worker pool then create the pool 
        ListOfWorkers = new List<Worker>();
        CreateWorkerPool(); 

    }

    public void CreateWorkerPool()
    {

        // Create the worker generator and then add the pool of workers
        WorkerGenerator tempWorkerGenerator = new WorkerGenerator();

        ListOfWorkers.Clear(); 

        for (int i = 0; i < iWORKERPOOLSIZE; i++)
        {
            ListOfWorkers.Add( tempWorkerGenerator.CreateWorker() ); 
        }

    }

    public Worker AddWorker()
    {

        // Returns a worker and then replaces that worker in the list
        Worker tempWorker = ListOfWorkers[Random.Range(0, ListOfWorkers.Count)];

        WorkerGenerator tempWorkerGenerator = new WorkerGenerator();
        ListOfWorkers[ListOfWorkers.IndexOf(tempWorker)] = tempWorkerGenerator.CreateWorker(); 

        return tempWorker; 

    }

}
