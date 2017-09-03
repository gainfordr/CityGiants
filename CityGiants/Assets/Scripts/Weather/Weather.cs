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
    public string sWeatherEffects { get; private set; }

    #endregion

    #region Functions

    public Weather()
    {
        // Base constructor, to be inherited and overriden by the specific weather types
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #endregion
}
