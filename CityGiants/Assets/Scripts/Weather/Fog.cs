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

public class Fog : Weather {

    #region Functions

    public Fog()
    {
        //Inherit setting functions to set it correctly
        base.AssignID(7);
        base.AssignName("Fog");

        GameObject tempSpr = null;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Forecast, 0);
        tempDict.Add(WeatherEffect.Defense, 1);
        base.AssignDictionary(tempDict);
    }

    public Fog(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(7);
        base.AssignName("Fog");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Forecast, 0);
        tempDict.Add(WeatherEffect.Defense, 1);
        base.AssignDictionary(tempDict);
    }

    #endregion

}
