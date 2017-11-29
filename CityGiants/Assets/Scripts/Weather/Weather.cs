using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: November 10th, 2017
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
    Food_Agriculture,       //Can be plus or minus (+1 or -1)
    Food_Fish,
    Food_Hunt,
    Food_WildProduce,
    Research_Regular,       //Can be plus (+1)
    Research_Arcane,
    Production,             //Can be minus (-1)
    Repairs,                //Can be none (0)
    Times,                  //Can be longer (+1)
    Forecast,               //Can be none, which will disable what can be seen on adjacent spaces (0)
    Defense,
    Construction,
    None

    //Keeping just in case things need to be reverted
    /*
    Food,           //Can be plus or minus (+1 or -1)
    Agriculture,
    Production,     //Can be minus (-1)
    Construction,   //Can be none (0)
    Research,        //Can be plus (+1)
    Arcane,
    Repairs,        //Can be none (0)
    Times,          //Can be longer (+1)
    Forecast,       //Can be none, which will disable what can be seen on adjacent spaces (0)
    Defense,
    Meat,
    None            //If no effect, will simply have this
    */
};

public class Weather : MonoBehaviour {

    #region Member Variables

    public int iId { get; private set; }
    public string sName { get; private set; }
    public GameObject sprParticle { get; private set; }
    public Dictionary<WeatherEffect,int> dWeatherEffects { get; private set; }
    public WeatherEffect weEffect { get; private set; }
    public WeatherRange enWeatherRange { get; private set; }
    

    #endregion

    #region Functions

    public Weather()
    {
        // Base constructor, to be inherited and overriden by the specific weather types
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

    public virtual void AssignID(int pId) { this.iId = pId; }
    public virtual void AssignName(string pName) { this.sName = pName;  }
    public virtual void AssignParticle(GameObject pGameObject) { this.sprParticle = pGameObject; }
    public virtual void AssignDictionary(Dictionary<WeatherEffect, int> pDict) { this.dWeatherEffects = pDict; }

    #endregion
}

