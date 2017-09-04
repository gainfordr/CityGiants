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

    void CycleWeatherEffects()
    {
        //This will apply the effects of all current weather in play
    }

    void Forecast()
    {
        //Terrain should be selected first, as the type of terrain will
        // modify what type of weather will be selected. EX: snow wont happen
        // in a desert terrain, or a heat wave in tundra 
        LandTerrain tempTerrain = SelectNewTerrain();


        //Once we know the new terrain, we take it and can figure out what weather we can have
        SelectNewWeather(tempTerrain);


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

    void SelectNewWeather(LandTerrain aTerrain)
    {
        //After a weathereffect is done, select a new weather effect
        // based on the weather given, so as to only allow certain weather

        //Will probably add in a random num to choose between however many weather
        // is allowed for a terrain type, maybe weigh the weathers differently 
    }

    LandTerrain SelectNewTerrain()
    {
        //Select a new terrain
        LandTerrain tempTerrain = new LandTerrain();

        //Might randomize which Terrain the tempTerrain will be
        // Different terrain weighted differently

        return tempTerrain;
    }
 

    #endregion
}
