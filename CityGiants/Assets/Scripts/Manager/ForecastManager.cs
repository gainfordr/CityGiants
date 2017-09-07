using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 6th, 2017
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
    public List<Weather> wMapWeather { get; private set; }
    public List<LandTerrain> ltMapTerrain { get; private set; }
    public Sprite[] sprParallaxBackground { get; private set; }
    public int iForecastLength = 3;

    public const int iWEATHERTYPEAMOUNT = 2;
    public const int iTERRAINTYPEAMOUNT = 3;
    public int iTimeLength { get; private set; }

    #endregion

    #region Functions

    void SetupManager()
    {
        //Used to initialize the values of the different
        //Weather and LandTerrain variants
        InitLandTerrain();
        InitWeather();

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
                    wMapWeather.Add(SelectNewWeather(ltTempTerrain));
                    ltMapTerrain.Add(ltTempTerrain);
                    break;

                case 2: //Grassland
                    ltTempTerrain = SelectNewTerrain(2);
                    wMapWeather.Add(SelectNewWeather(ltTempTerrain));
                    ltMapTerrain.Add(ltTempTerrain);
                    break;

                case 3: //Tundra
                    ltTempTerrain = SelectNewTerrain(3);
                    wMapWeather.Add(SelectNewWeather(ltTempTerrain));
                    ltMapTerrain.Add(ltTempTerrain);
                    break;

                case 4: //Lake

                    SelectNewWeather(ltTempTerrain);
                    break;

                case 5: //Mountain

                    SelectNewWeather(ltTempTerrain);
                    break;

                case 6: //Swamp

                    SelectNewWeather(ltTempTerrain);
                    break;

                case 7: //Desert

                    SelectNewWeather(ltTempTerrain);
                    break;

                case 8: //Jungle

                    SelectNewWeather(ltTempTerrain);
                    break;

                case 9: //Wasteland

                    SelectNewWeather(ltTempTerrain);
                    break;
            }
        }

        

    }

    void CycleWeatherEffects()
    {
        //This will apply the effects of all current weather in play

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
                return wTempWeather;

            case 4: //Snow
                return wTempWeather;

            case 5: //Windy
                return wTempWeather;

            case 6: //Thunderstorm
                return wTempWeather;

            case 7: //Hail
                return wTempWeather;

            case 8: //Fog
                return wTempWeather;

            case 9: //HeatWave
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
                
                break;

            case 5: //Mountain

                
                break;

            case 6: //Swamp

               
                break;

            case 7: //Desert

               
                break;

            case 8: //Jungle

                break;

            case 9: //Wasteland
                break;
        }


        return tempTerrain;
    }


    void SetCurrentWeather(Weather aWeather)
    {
        wCurrentweather = aWeather;
        iTimeLength = InitWeatherLength(wCurrentweather.enWeatherRange);
    }

    void SetCurrentTerrain(LandTerrain aLandTerrain)
    {
        //When called, will set the terrain to the specific terrain given
        //Will also set the parallax background to what the terrain has
        ltCurrentTerrain = aLandTerrain;
        sprParallaxBackground = ltCurrentTerrain.sprSprite;

    }

    void HandleParallax()
    {
        // Function to handle the parallax background for each terrain
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
