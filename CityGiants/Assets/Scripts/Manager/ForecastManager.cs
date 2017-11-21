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
    public int iForecastLength { get; private set; }                //How far the player can see for weather + landterrain, also is how long each of the lists should be

    private const int iDEFAULTFORECASTLENGTH = 3;                   //Const to init the forecast length to
    private const int iWEATHERTYPEAMOUNT = 9;
    private const int iTERRAINTYPEAMOUNT = 9;
    public int iTimeLength { get; private set; }                    //How long will weather last for (default is 3)

    #endregion

    #region Functions

    /// <summary>
    /// Called to begin the setup of the Weather and LandTerrain forecasts, respectively.
    /// </summary>
    void SetupManager()
    {
        //Used to initialize the values of the different
        //Weather and LandTerrain variants
        iForecastLength = iDEFAULTFORECASTLENGTH;
        //Sets the current weather and current terrain to start
        SetupForecast();
    }

    /// <summary>
    /// Initializes the Lists of Weather and LandTerrain, and randomly assigns values
    /// Assigns the index 0 to the currentWeather and currentTerrain, respectively.
    /// </summary>
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

    /// <summary>
    /// Called to cycle through WeatherEffects based on iTimeLength, and assign new values if needed.
    /// </summary>
    void CycleWeatherEffects()
    {
        //This will apply the effects of all current weather in play

        //Decrement the iTimeLength by 1, to denote the passing of a day (Called by endTurn)
        iTimeLength--;

        //if iTimeLength is equal to 0, time to do some changes to the forecast
        if (iTimeLength == 0)
        {
            //First, need to shift the elements of wOBjs
            //These are what is currently put down as the current Weather and LandTerain, respectively
            wObjs.RemoveAt(0); //this will remove the first element and shift elements down
            //Next, add the new index 0 as the current weather
            wCurrentWeather = wObjs[0];
            //Once that is complete, need to apply a new Weather at the end of the wObjs list
            //This will be done by accessing the current Terrain to see which is accesible
            wObjs.Add(SelectNewWeather(ltCurrentTerrain));
            //Once that has been done, reset the iTimeLength to 3 and the cycle will begin anew
            iTimeLength = 3;

            // TODO : Need to remind myself, for UI, that fog should just disable seeing what
            //          The next choice of weather is, don't actually modify the Lists
        }
    }

    /// <summary>
    /// Changes the current LandTerrain, based on having "traversed" it
    /// </summary>
    void CycleLandTerrain()
    {
        //This will change the current terrain, based on having "traversed" it

        //Need to shift the values
        ltObjs.RemoveAt(0);
        //Set the current terrain to the new ltObjs at index 0
        ltCurrentTerrain = ltObjs[0];
        //Add a new Terrain to the end of 
        int iTempNum = Random.Range(1, iTERRAINTYPEAMOUNT);
        ltObjs.Add(SelectNewTerrain(iTempNum));
    }

    /// <summary>
    /// Based on the LandTerrain given, will create and return a new Weather object
    /// </summary>
    /// <param name="aTerrain"></param>
    /// <returns></returns>
    public Weather SelectNewWeather(LandTerrain aTerrain)
    {
        //After a weathereffect is done, select a new weather effect
        // based on the terrain given, so as to only allow certain weather
        int iTempNum = Random.Range(1, iWEATHERTYPEAMOUNT);
        Weather wTempWeather = new Weather();

        //Based on the Terrain given, will have a weighted chance as to what weather will
        //be based on what terrain is given. Example: cant be rain in the desert

        //Need to create a basic int array, which will hold the possible choices based on
        //  Index 0 being most likely, and Index 3 being least likely
        int[] iTempArray = new int[4];

        //NOTE: current values inside array of ints is placeholder, once the choices have been finalized,
        //      they will be changed to the appropriate values
        switch(aTerrain.iId)
        {
            case 1:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 2:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 3:
                iTempArray = new int[]{ 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 4:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 5:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 6:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 7:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 8:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            case 9:
                iTempArray = new int[] { 1, 2, 3, 4 };
                wTempWeather = WeatherWeightedRandom(iTempArray);
                return wTempWeather;

            default: //If this occurs, assume error
                return wTempWeather;
        }

    }

    /// <summary>
    /// Given an array of choices, randomly assigns a new Weather based on weighted values
    /// </summary>
    /// <param name="pChoiceArray">Used to indicate which Weather, with first being most likely</param>
    /// <returns>Returns a Weather object, the result of the weighted random selection</returns>
    public Weather WeatherWeightedRandom(int[] pChoiceArray)
    {
        // Moving the weighted random chance calculations to a seperate function, to avoid clutter
        //From the intArray parameter, first value is considered most likely, with last value
        //being the least likely choice

        //For sanity sake, for now, there are 4 choices of weather weighted in the following
        // 1) 40% chance (highly likely)
        // 2) 30% chance (uncommon)
        // 3) 20% chance (rare)
        // 4) 10% chance (highly unlikely)

        //Create a temp weather object
        Weather wTempObj = new Weather();

        if (Random.value <= 1.0f && Random.value >= 0.61f) //High Chance
        {
            wTempObj = RandomWeatherRange(pChoiceArray[0]);
        }
        else if (Random.value <= 0.6f && Random.value >= 0.31f) //Uncommon
        {
            wTempObj = RandomWeatherRange(pChoiceArray[1]);
        }
        else if (Random.value <= 0.3f && Random.value >= 0.1f) //rare
        {
            wTempObj = RandomWeatherRange(pChoiceArray[2]);
        }
        else //Unlikely
        {
            wTempObj = RandomWeatherRange(pChoiceArray[3]);
        }

        return wTempObj;
    }

    /// <summary>
    /// Returns a specific Weather class based on the value of parameter iRange
    /// </summary>
    /// <param name="iRange">Specific choice of Weather Object</param>
    /// <returns>wTempWeather</returns>
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

    /// <summary>
    /// Returns a specific LandTerrain class based on the value of parameter iRange
    /// </summary>
    /// <param name="iRange"></param>
    /// <returns></returns>
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

    /// <summary>
    /// Sets the current Weather to the given parameter of aWeather
    /// </summary>
    /// <param name="aWeather"></param>
    void SetCurrentWeather(Weather aWeather)
    {
        wCurrentWeather = aWeather;
        iTimeLength = InitWeatherLength(wCurrentWeather.enWeatherRange);
    }

    /// <summary>
    /// Sets the current LandTerrain to the given parameter of aLandTerrain
    /// </summary>
    /// <param name="aLandTerrain"></param>
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

    /// <summary>
    /// Takes a parameter of WeatherRange, and returns a random value based on what
    /// size the WeatherRange is
    /// </summary>
    /// <param name="aWeatherRange"></param>
    /// <returns></returns>
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
