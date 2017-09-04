using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 3rd, 2017
 * 
 * Description: Inherits from LandTerrain, used for the specific terrain effects
 * 
 * 
 */

public class Tundra : LandTerrain {

    #region Member Variables

    public Sprite[] sprSpriteTundra { get; private set; }
    public string[] sEffectsTundra { get; private set; }
    public string sNameTundra { get; private set; }
    public MoveRange enRangeTundra { get; private set; }
    public ExpeditionAvailability enAvailTundra { get; private set; }

    #endregion


    #region Functions

    public Tundra() : base ()
    {

    }

    public Tundra(Sprite[] aSprite, string[] aEffects, string aName, MoveRange aRange, ExpeditionAvailability aAvail) 
        : base(aSprite, aEffects, aName, aRange, aAvail)
    {
        //Inherited and overriding the base constructor with appropriate info
        this.sprSpriteTundra = aSprite;
        this.sEffectsTundra = aEffects;
        this.sNameTundra = aName;
        this.enRangeTundra = aRange;
        this.enAvailTundra = aAvail;
    }

    #endregion
}
