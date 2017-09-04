using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: September 3rd, 2017
 * 
 * Description: Inherits from LandTerrain, used for the specific terrain type
 * 
 * 
 */

public class Forest : LandTerrain {

    #region Member Variables

    public Sprite[] sprSpriteForest { get; private set; }
    public string[] sEffectsForest { get; private set; }
    public string sNameForest { get; private set; }
    public MoveRange enRangeForest { get; private set; }
    public ExpeditionAvailability enAvailForest { get; private set; }

    #endregion

    #region Functions

    public Forest() : base()
    {

    }

    public Forest(Sprite[] aSprite, string[] aEffects, string aName, MoveRange aRange, ExpeditionAvailability aAvail) 
        : base(aSprite, aEffects, aName, aRange, aAvail)
    {
        //Inherited and overriding the base constructor with appropriate info
        this.sprSpriteForest = aSprite;
        this.sEffectsForest = aEffects;
        this.sNameForest = aName;
        this.enRangeForest = aRange;
        this.enAvailForest = aAvail;
    }


    #endregion
}
