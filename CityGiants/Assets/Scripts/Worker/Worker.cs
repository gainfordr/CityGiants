using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *****************************************************************************
// Author: Ryan Gainford
// Created: August 12, 2017 
// Updated: August 12, 2017
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

    public int iFarmer { get; private set; }
    public int iGatherer { get; private set; }
    public int iCrafter { get; private set; }
    public int iAdventurer { get; private set; }
    public int iResearcher { get; private set; }
    public int iMilitary { get; private set; }
    public int iBuilder { get; private set; }

    #endregion

    public Worker()
    {

        sName = "";
        iHealth = 0;
        sprSprite = null;

        iFarmer = 0;
        iGatherer = 0;
        iCrafter = 0;
        iAdventurer = 0;
        iResearcher = 0;
        iMilitary = 0;
        iBuilder = 0;

    }

    public void CreateWorker()
    {

        NameGenerator tempGenerator = new NameGenerator();

        sName = tempGenerator.GenerateNewName();

        iFarmer = Random.Range(1, 10);
        iGatherer = Random.Range(1, 10);
        iCrafter = Random.Range(1, 10);
        iAdventurer = Random.Range(1, 10);
        iResearcher = Random.Range(1, 10);
        iMilitary = Random.Range(1, 10);
        iBuilder = Random.Range(1, 10);

    }

}


public class NameGenerator
{

    #region First Names

    private string[] FirstNames = new string[] { "John", "Sam", "Lucy", "Garfield", "Cindy", "Cassidy", "Elvis", "Joan", "Johnny", "Samantha", "Eliza", "George", "Cassidy",
                                                 "Lindsey" };

    #endregion

    #region Last Names

    private string[] LastNames = new string[] { "Gainford", "Smith", "Fletcher", "Fitzgerald" };

    #endregion

    public string GenerateNewName ()
    {
        return FirstNames[ Random.Range(0, FirstNames.Length) ] + " " + LastNames[ Random.Range(0, LastNames.Length) ];
    }

}
