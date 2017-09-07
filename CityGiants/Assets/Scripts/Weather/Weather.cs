using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 6th, 2017
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

public enum WeatherEffect
{
    Food,           //Can be plus or minus (+1 or -1)
    Production,     //Can be minus (-1)
    Construction,   //Can be none (0)
    Science,        //Can be plus (+1)
    Repairs,        //Can be none (0)
    Times,          //Can be longer (+1)
    Forecast,       //Can be none, which will disable what can be seen on adjacent spaces (0)
    None            //If no effect, will simply have this
};

public class Weather : MonoBehaviour {

    #region Member Variables

    public GameObject sprParticle { get; private set; }
    public Sprite sprSprite { get; private set; }
    public string sName { get; private set; }
    public Dictionary<WeatherEffect,int> dWeatherEffects { get; private set; }
    public WeatherEffect weEffect { get; private set; }
    public WeatherRange enWeatherRange { get; private set; }
    

    #endregion

    #region Functions

    public Weather()
    {
        // Base constructor, to be inherited and overriden by the specific weather types
    }

    public Weather(GameObject aParticle, Sprite aSprite, string aName, Dictionary<WeatherEffect, int> aWeatherEffects, WeatherRange aWeatherRange, bool aWeatherStatus, bool aParticleStatus)
    {
        // Base constructor, to be inherited and overriden by the specific weather types
        this.sprParticle = aParticle;
        this.sprSprite = aSprite;
        this.sName = aName;
        this.dWeatherEffects = aWeatherEffects;
    }

    public void WeatherEffectToggle(bool bIsEnabled)
    {
        //Until I get a better idea of how it should toggle, 
        // this should work well enough
        this.enabled = bIsEnabled;
    }

    public void WeatherParticleToggle(bool bIsEnabled)
    {
        //Until I get a better idea of how it should toggle, 
        // this should work well enough
        if (this.sprParticle.activeSelf == false)
            this.sprParticle.SetActive(true);
        else
            this.sprParticle.SetActive(false);
    }
    

    #endregion
}

