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

        iFood = 0;
        iMaterial = 0;

        iMaxFood = 0;
        iMaxMaterial = 0;

    }

    public void SetupManager()
    {

        // For starting a new game
        // Modded by Giants and Celestials in their respective classes
        iFood = iSTARTFOOD;
        iMaterial = iSTARTMATERIAL;

        iMaxFood = iSTARTMAXFOOD;
        iMaxMaterial = iSTARTMAXMATERIAL; 

    }

    #region Variable Setters

    // When changing resource counts the following should always be true:
    //   * Resource should never be negative
    //   * Resource should never exceed its max

    public void ModFood( int aValue )
    {
        
        if (iFood + aValue < 0)
            iFood = 0;

        else if (iFood + aValue > iMaxFood)
            iFood = iMaxFood;

        else
            iFood += aValue;  

    }

    public void ModMaxFood( int aValue )
    {
        iMaxFood += aValue;
    }


    public void ModMaterial( int aValue )
    {

        if (iMaterial + aValue < 0)
            iMaterial = 0;

        else if (iMaterial + aValue > iMaxMaterial)
            iMaterial = iMaxMaterial;

        else
            iMaterial += aValue; 

    }

    public void ModMaxMaterial( int aValue )
    {
        iMaxMaterial += aValue; 
    }

    #endregion

}
