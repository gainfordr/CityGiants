using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// *****************************************************************************
// Author: Ryan Gainford
// Created: September 3, 2017 
// Updated: September 3, 2017
//
// Description: Handles all of the resources in the game. This includes the 
// base resources, advanced resources, and luxuries.  
//
// *****************************************************************************

public class M_Resource : MonoBehaviour
{

    #region Member Variables

    public int iFood { get; private set; }
    public int iMaterial { get; private set; }

    public int iMaxFood { get; private set; }
    public int iMaxMaterial { get; private set; }

    // Initial values on starting a new game
    const int iSTARTFOOD = 10;
    const int iSTARTMATERIAL = 10;

    const int iSTARTMAXFOOD = 50;
    const int iSTARTMAXMATERIAL = 50; 

    #endregion

    public M_Resource()
    {

        // Initialize all to base values

    }

    public void SetupManager()
    {

        // Used for game startup
        // Later on for loading a game
        // Effectively just creates the initial game starting values
        // Any effects brought in by celestials or giants will be done here

    }

    #region Variable Setters

    // Mods the current value and maximum of resources in the game
    // Functions will also take into consideration the maximums and negative values

    public void ModFood( int aValue )
    {

        // Needs to take into consideration the maximum amount

    }

    public void ModMaxFood( int aValue )
    {

    }


    public void ModMaterial( int aValue )
    {

        // Needs to take into consideration the minimum amount

    }

    public void ModMaxMaterial( int aValue )
    {

    }

    #endregion

}
