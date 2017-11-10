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

public class Thunderstorm : Weather {

    #region Functions
    public Thunderstorm(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(5);
        base.AssignName("Thunderstorm");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Construction, 0);
        tempDict.Add(WeatherEffect.Research, 1);
        base.AssignDictionary(tempDict);
    }
    #endregion 
}
