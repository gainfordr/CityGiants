using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 3rd, 2017
 * 
 * Description: Holds all the variables needed for objects of the LandTerrain class
 * 
 * 
 */

public enum ExpeditionAvailability
{
    Low,
    Average,
    High,
    Extreme
};

public enum MoveRange
{
    Short,
    Average,
    Long
};

public class LandTerrain {

    #region Member Variables

    public Sprite[] sprSprite { get; private set; }
    public string[] sEffects { get; private set; }
    public string sName { get; private set; }
    public MoveRange enRange { get; private set; }
    public ExpeditionAvailability enAvail { get; private set; }

    #endregion

    public LandTerrain()
    {
        // Base constructor, to be inherited and overriden by the specific weather types
        this.sprSprite = null;
        this.sEffects = null;
        this.sName = null;
        this.enRange = MoveRange.Short;
        this.enAvail = ExpeditionAvailability.Low;
    }

    public LandTerrain(Sprite[] aSprite, string[] aEffects, string aName, MoveRange aRange, ExpeditionAvailability aAvail)
    {
        this.sprSprite = aSprite;
        this.sEffects = aEffects;
        this.sName = aName;
        this.enRange = aRange;
        this.enAvail = aAvail;
    }

}
