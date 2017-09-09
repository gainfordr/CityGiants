using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *****************************************************************************
// Author: Ryan Gainford
// Created: August 12, 2017 
// Updated: September 4, 2017
//
// Description: Contains the base worker class object that defines its traits 
// and other important variables. 
//
// *****************************************************************************

public class Worker : MonoBehaviour
{

    #region Member Variables

    public string sName { get; private set; }
    public int iHealth { get; private set; }
    public Sprite sprSprite { get; private set; }

    public int iTraitFarmer { get; private set; }
    public int iTraitGatherer { get; private set; }
    public int iTraitCrafter { get; private set; }
    public int iTraitAdventurer { get; private set; }
    public int iTraitResearcher { get; private set; }
    public int iTraitMilitary { get; private set; }
    public int iTraitBuilder { get; private set; }

    #endregion

    public Worker()
    {

        NameGenerator tempGenerator = new NameGenerator();

        sName = tempGenerator.GenerateNewName();

        iTraitFarmer = Random.Range(1, 10);
        iTraitGatherer = Random.Range(1, 10);
        iTraitCrafter = Random.Range(1, 10);
        iTraitAdventurer = Random.Range(1, 10);
        iTraitResearcher = Random.Range(1, 10);
        iTraitMilitary = Random.Range(1, 10);
        iTraitBuilder = Random.Range(1, 10);

    }

}


public class WorkerGenerator
{

    // Cut out the create worker from the Worker class and make a generator for it 
    // to create workers. No reason to make a worker to call create worker. 

    public WorkerGenerator()
    {

    }

    public Worker CreateWorker()
    {
        Worker tempWorker = new Worker();
        return tempWorker;  
    }

}


public class NameGenerator
{

    #region Member Variables

    private string[] FirstNames = new string[] { "John", "Sam", "Lucy", "Garfield", "Cindy", "Cassidy", "Elvis", "Joan", "Johnny", "Samantha", "Eliza", "George", "Cassidy",
                                                 "Lindsey" };

    private string[] LastNames = new string[] { "Gainford", "Smith", "Fletcher", "Fitzgerald" };

    #endregion

    public string GenerateNewName ()
    {
        return FirstNames[ Random.Range(0, FirstNames.Length) ] + " " + LastNames[ Random.Range(0, LastNames.Length) ];
    }

}
