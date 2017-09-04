using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 3rd, 2017
 * 
 * Description: Holds the variables needed for an object of the weather class
 * 
 * 
 */

public enum WeatherRange
{
    Short,
    Medium,
    Long
};

public class Weather {

    #region Member Variables

    public Sprite sprParticle { get; private set; }
    public Sprite sprSprite { get; private set; }
    public string sName { get; private set; }
    public string[] sWeatherEffects { get; private set; }
    public WeatherEffect weEffect { get; private set; }
    public WeatherRange enWeatherRange { get; private set; }
    public bool bWeatherStatus { get; private set; }
    public bool bParticleStatus { get; private set; }

    #endregion

    #region Functions

    public Weather()
    {
        // Base constructor, to be inherited and overriden by the specific weather types
    }

    public Weather(Sprite aParticle, Sprite aSprite, string aName, string[] aWeatherEffects, WeatherEffect aEffect, WeatherRange aWeatherRange, bool aWeatherStatus, bool aParticleStatus)
    {
        // Base constructor, to be inherited and overriden by the specific weather types
        this.sprParticle = aParticle;
        this.sprSprite = aSprite;
        this.sName = aName;
        this.sWeatherEffects = aWeatherEffects;
    }

    public void WeatherEffectToggle(bool aWeatherStatus)
    {
        //Until I get a better idea of how it should toggle, 
        // this should work well enough
        this.bWeatherStatus = aWeatherStatus;
    }

    public void WeatherParticleToggle(bool aParticleStatus)
    {
        //Until I get a better idea of how it should toggle, 
        // this should work well enough
        this.bParticleStatus = aParticleStatus;
    }
    

    #endregion
}

public class WeatherEffect
{
    #region Member Variables

    public string[] sWeatherEffects { get; private set; }

    #endregion

    #region Functions

    public WeatherEffect(string[] aWeatherEffects)
    {
        this.sWeatherEffects = aWeatherEffects;
    }

    public void ApplyWeatherEffect()
    {
        /* This function will take the list of strings for the weather effects, 
         * read it, and then apply the appropriate effect for what weather effect is
         * Will need to be hooked up and manipulate the right manager
         * 
         */
    }

    #endregion
}
