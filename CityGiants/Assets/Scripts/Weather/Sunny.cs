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

public class Sunny : Weather {

    #region Member Variables

    public GameObject sprParticleSunny { get; private set; }
    public Sprite sprSpriteSunny { get; private set; }
    public string sNameSunny { get; private set; }
    public Dictionary<WeatherEffect, int> dWeatherEffectsSunny { get; private set; }
    public WeatherRange enWeatherRangeSunny { get; private set; }
    public bool bWeatherStatusSunny { get; private set; }
    public bool bParticleStatusSunny { get; private set; }

    #endregion 

    #region Functions

    public Sunny() : base()
    {
        //Inherited and overriding the base constructor with appropriate info
    }

    public Sunny(GameObject aParticle, Sprite aSprite, string aName, Dictionary<WeatherEffect, int> aWeatherEffects, WeatherRange aWeatherRange, bool aWeatherStatus, bool aParticleStatus) 
        : base(aParticle, aSprite, aName, aWeatherEffects, aWeatherRange,aWeatherStatus, aParticleStatus)
    { 
        //Inherited and overriding the base constructor with appropriate info
    }

    #endregion
}
