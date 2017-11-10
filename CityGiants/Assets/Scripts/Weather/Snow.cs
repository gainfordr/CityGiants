using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: November 10th, 2017
 * Updated: November 10th, 2017
 * 
 * Description: Inherits from Weather, used for the specific weather
 * 
 * 
 */

public class Snow : Weather {

    #region Functions

    public Snow(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(3);
        base.AssignName("Snow");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.None, 0);
        base.AssignDictionary(tempDict);
    }

    #endregion 
}
