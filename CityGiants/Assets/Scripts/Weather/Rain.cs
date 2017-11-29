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

public class Rain : Weather {


    #region Functions

    public Rain()
    {
        //Inherit setting functions to set it correctly
        base.AssignID(0);
        base.AssignName("Rain");

        GameObject tempSpr = null;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food_Agriculture, 1);
        tempDict.Add(WeatherEffect.Production, -1);
        base.AssignDictionary(tempDict);
    }

    public Rain(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(0);
        base.AssignName("Rain");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food_Agriculture, 1);
        tempDict.Add(WeatherEffect.Production, -1);
        base.AssignDictionary(tempDict);
    }

    #endregion
}
