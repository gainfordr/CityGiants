using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: November 10th, 2017
 * 
 * Description: Holds the variables of types Weather and LandTerrain,
 * holds the parallax (landTerrain) and Particles[], the current weather
 * + terrain, and setup.
 * 
 */

public class ForecastManager : MonoBehaviour {

    #region Member Variables

    public List<LandTerrain> ltObjs { get; private set; }           //Array of LandTerrain Objects, of forecastLength
    public List<Weather> wObjs { get; private set; }                //Array of Weather Objects, of forecastLength
    public Weather wCurrentWeather { get; private set; }            //Reference to current Weather in play
    public LandTerrain ltCurrentTerrain { get; private set; }       //Reference to current Terrain in play
    public Sprite[] sprParallaxBackground { get; private set; }     //Reference to sprites used to illustrate the parallax background
    public int iForecastLength { get; private set; }

    private const int iDEFAULTFORECASTLENGTH = 3;                   //Const to init the forecast length to
    private const int iWEATHERTYPEAMOUNT = 9;
    private const int iTERRAINTYPEAMOUNT = 9;
    public int iTimeLength { get; private set; }

    #endregion

    #region Functions

    void SetupManager()
    {
        //Used to initialize the values of the different
        //Weather and LandTerrain variants
        iForecastLength = iDEFAULTFORECASTLENGTH;
        //Sets the current weather and current terrain to start
        SetupForecast();
    }

    void SetupForecast()
    {
        //Sets the current weather and current terrain in one go
        // For now can set it just to the first, until I can think
        // of a better way to do so

        //Will set up to know what weather is at least three spaces ahead
        int iTempNum = Random.Range(1, iTERRAINTYPEAMOUNT);
        LandTerrain ltTempTerrain = new LandTerrain();

        for (int i = 0; i < iForecastLength; i++)
        {
            switch (iTempNum)
            {
                case 1: //Forest
                    ltTempTerrain = SelectNewTerrain(1);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 2: //Grassland
                    ltTempTerrain = SelectNewTerrain(2);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 3: //Tundra
                    ltTempTerrain = SelectNewTerrain(3);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 4: //Lake
                    ltTempTerrain = SelectNewTerrain(4);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 5: //Mountain
                    ltTempTerrain = SelectNewTerrain(5);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 6: //Swamp
                    ltTempTerrain = SelectNewTerrain(6);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 7: //Desert
                    ltTempTerrain = SelectNewTerrain(7);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 8: //Jungle
                    ltTempTerrain = SelectNewTerrain(8);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;

                case 9: //Wasteland
                    ltTempTerrain = SelectNewTerrain(9);
                    wObjs.Add(SelectNewWeather(ltTempTerrain));
                    ltObjs.Add(ltTempTerrain);
                    break;
            }
        }

        SetCurrentWeather(wObjs[0]);
        SetCurrentTerrain(ltObjs[0]);
    }

    void CycleWeatherEffects()
    {
        //This will apply the effects of all current weather in play

    }


    public Weather SelectNewWeather(LandTerrain aTerrain)
    {
        //After a weathereffect is done, select a new weather effect
        // based on the terrain given, so as to only allow certain weather
        int iTempNum = Random.Range(1, iWEATHERTYPEAMOUNT);
        Weather wTempWeather = new Weather();
        
        switch(aTerrain.sName)
        {
            case "Forest":
                if (iTempNum == 1)
                    wTempWeather = RandomWeatherRange(1);
                else if(iTempNum == 2)
                     wTempWeather = RandomWeatherRange(2);
                return wTempWeather;

            case "Grassland":
                if (iTempNum == 1)
                    wTempWeather = RandomWeatherRange(1);
                else if (iTempNum == 2)
                    wTempWeather = RandomWeatherRange(2);
                return wTempWeather;

            case "Tundra":
                break;

            case "Wasteland":
                break;

            case "Jungle":
                break;

            case "Lake":
                break;

            case "Mountain":
                break;

            case "Desert":
                break;

            case "Swamp":
                break;

            default:
                return wTempWeather;
        }

        return wTempWeather;
    }

    public Weather RandomWeatherRange(int iRange)
    {
        Weather wTempWeather = new Weather();

        switch(iRange)
        {
            case 1: //Sunny
                wTempWeather = new Sunny();
                return wTempWeather;

            case 2: //Rain
                wTempWeather = new Rain();
                return wTempWeather;

            case 3: //Cloudy
                wTempWeather = new Cloudy();
                return wTempWeather;

            case 4: //Snow
                wTempWeather = new Snow();
                return wTempWeather;

            case 5: //Windy
                wTempWeather = new Windy();
                return wTempWeather;

            case 6: //Thunderstorm
                wTempWeather = new Thunderstorm();
                return wTempWeather;

            case 7: //Hail
                wTempWeather = new Hail();
                return wTempWeather;

            case 8: //Fog
                wTempWeather = new Fog();
                return wTempWeather;

            case 9: //HeatWave
                wTempWeather = new HeatWave();
                return wTempWeather;
        }

        return wTempWeather;
    }

    LandTerrain SelectNewTerrain(int iRange)
    {
        //Select a new terrain
        LandTerrain tempTerrain = new LandTerrain();

        //Might randomize which Terrain the tempTerrain will be
        // Different terrain weighted differently

        switch (iRange)
        {
            case 1: //Forest
                tempTerrain = new Forest();
                return tempTerrain;

            case 2: //Grassland
                tempTerrain = new Grassland();
                return tempTerrain;

            case 3: //Tundra
                tempTerrain = new Tundra();
                return tempTerrain;

            case 4: //Lake
                tempTerrain = new Lake();
                break;

            case 5: //Mountain
                tempTerrain = new Mountain();
                break;

            case 6: //Swamp
                tempTerrain = new Swamp();
                break;

            case 7: //Desert
                tempTerrain = new Desert();
                break;

            case 8: //Jungle
                tempTerrain = new Jungle();
                break;

            case 9: //Wasteland
                tempTerrain = new Wasteland();
                break;
        }


        return tempTerrain;
    }


    void SetCurrentWeather(Weather aWeather)
    {
        wCurrentWeather = aWeather;
        iTimeLength = InitWeatherLength(wCurrentWeather.enWeatherRange);
    }

    void SetCurrentTerrain(LandTerrain aLandTerrain)
    {
        //When called, will set the terrain to the specific terrain given
        //Will also set the parallax background to what the terrain has
        ltCurrentTerrain = aLandTerrain;
        //sprParallaxBackground = ltCurrentTerrain.sprSprite;

    }

    void HandleParallax()
    {
        // Function to handle the parallax background for each terrain
        
        //Center layer moves at a uniform speed

        //Two foreground layers will have a speed relatively lower than the center layer

        //Two background layers will have a speed relatively higher than the center layer
    }

    //Given the weatherrange, it will set the time length on
    // the weatherrange
    public int InitWeatherLength(WeatherRange aWeatherRange)
    {
        int iTemp = 0;

        if(aWeatherRange == WeatherRange.Short)
        {
            iTemp = Random.Range(1, 5);
            return iTemp;
        }
        else if(aWeatherRange == WeatherRange.Medium)
        {
            iTemp = Random.Range(6, 8);
            return iTemp;
        }
        else
        {
            iTemp = Random.Range(9, 10);
            return iTemp;
        }

    }
    
    void Update()
    {
        //Reason to keep the update function is to keep updating the parallax function
        HandleParallax();
    }


    #endregion
}
