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

public class HeatWave : Weather {

    #region Functions

    public HeatWave()
    {
        //Inherit setting functions to set it correctly
        base.AssignID(8);
        base.AssignName("HeatWave");

        GameObject tempSpr = null;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food_Agriculture, -1);
        tempDict.Add(WeatherEffect.Production, -1);
        tempDict.Add(WeatherEffect.Defense, 1);
        tempDict.Add(WeatherEffect.Food_Hunt, 1);
        base.AssignDictionary(tempDict);
    }

    public HeatWave(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(8);
        base.AssignName("HeatWave");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food_Agriculture, -1);
        tempDict.Add(WeatherEffect.Production, -1);
        tempDict.Add(WeatherEffect.Defense, 1);
        tempDict.Add(WeatherEffect.Food_Hunt, 1);
        base.AssignDictionary(tempDict);
    }

    #endregion 
}
