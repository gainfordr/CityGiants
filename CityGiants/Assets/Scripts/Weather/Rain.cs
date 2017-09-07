using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 6th, 2017
 * 
 * Description: Inherits from Weather, used for the specific weather
 * 
 * 
 */

public class Rain : Weather {

    #region Member Variables

    public GameObject sprParticleRain { get; private set; }
    public Sprite sprSpriteRain { get; private set; }
    public string sNameRain { get; private set; }
    public Dictionary<WeatherEffect, int> dWeatherEffectsRain { get; private set; }
    public WeatherRange enWeatherRangeRain { get; private set; }
    public bool bWeatherStatusRain { get; private set; }
    public bool bParticleStatusRain { get; private set; }

    #endregion

    #region Functions

    public Rain() : base()
    {
        //Inherited and overriding the base constructor with appropriate info
    }

    public Rain(GameObject aParticle, Sprite aSprite, string aName, Dictionary<WeatherEffect, int> aWeatherEffects, WeatherRange aWeatherRange, bool aWeatherStatus, bool aParticleStatus) 
        : base(aParticle, aSprite, aName, aWeatherEffects, aWeatherRange, aWeatherStatus, aParticleStatus)
    {
        //Inherited and overriding the base constructor with appropriate info
    }

    #endregion
}
