using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 3rd, 2017
 * 
 * Description: Holds the variables of types Weather and LandTerrain,
 * holds the parallax (landTerrain) and Particles[], the current weather
 * + terrain, and setup.
 * 
 */

public class ForecastManager : MonoBehaviour {

    #region Member Variables

    public List<LandTerrain> ltObjs { get; private set; }
    public List<Weather> wObjs { get; private set; }
    public Weather wCurrentweather { get; private set; }
    public LandTerrain ltCurrentTerrain { get; private set; }
    public Sprite sprWeatherParticle { get; private set; }
    public Sprite[] sprParallaxBackground { get; private set; }

    public int iTimeLength { get; private set; }

    #endregion

    #region Functions

    void SetupManager()
    {
        //Used to initialize the values of the different
        //Weather and LandTerrain variants
        InitLandTerrain();
        InitWeather();

    }

    //Inits a list of Weather objects for all the Weather types
    void InitWeather()
    {
        wObjs = new List<Weather>();
        wObjs.Add(new Rain());
        wObjs.Add(new Sunny());
    }

    //Inits a list of LandTerrain objects for all LandTerrain types
    void InitLandTerrain()
    {
        ltObjs = new List<LandTerrain>();
        ltObjs.Add(new Grassland());
        ltObjs.Add(new Tundra());
        ltObjs.Add(new Forest());
    }

    void SelectNewWeather()
    {
        //After a weathereffect is done, select a new weather effect
    }

    void SelectNewTerrain()
    {
        //Select a new terrain after 
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #endregion
}
