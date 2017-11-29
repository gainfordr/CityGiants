using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: November 10th, 2017
 * 
 * Description: Inherits from Weather, used for the specific weather
 * 
 * 
 */

public class Sunny : Weather {


    #region Functions

    public Sunny()
    {
        //Inherit setting functions to set it correctly
        base.AssignID(0);
        base.AssignName("Sunny");

        GameObject tempSpr = null;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food_Agriculture, 1);
        tempDict.Add(WeatherEffect.Research_Regular, -1);
        base.AssignDictionary(tempDict);
    }

    public Sunny(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(0);
        base.AssignName("Sunny");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food_Agriculture, 1);
        tempDict.Add(WeatherEffect.Research_Regular, -1);
        base.AssignDictionary(tempDict);
    }

   #endregion
}
