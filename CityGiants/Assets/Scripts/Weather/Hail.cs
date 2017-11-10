﻿using System.Collections;
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

public class Hail : Weather {

    #region Functions

    public Hail(GameObject pSpr)
    {
        //Inherit setting functions to set it correctly
        base.AssignID(6);
        base.AssignName("Hail");

        GameObject tempSpr = pSpr;
        base.AssignParticle(tempSpr);

        Dictionary<WeatherEffect, int> tempDict = new Dictionary<WeatherEffect, int>();
        tempDict.Add(WeatherEffect.Food, -1);
        tempDict.Add(WeatherEffect.Construction, 0);
        tempDict.Add(WeatherEffect.Research, 1);
        tempDict.Add(WeatherEffect.Arcane, 1);
        tempDict.Add(WeatherEffect.Defense, 1);
        base.AssignDictionary(tempDict);
    }

    #endregion 
}
