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

public class Grassland : LandTerrain {

    #region Member Variables

    public Sprite[] sprSpriteGrassland { get; private set; }
    public Dictionary<ResourceList,int> dResourcesGrassland { get; private set; }
    public string sNameGrassland { get; private set; }
    public MoveRange enRangeGrassland { get; private set; }
    public ExpeditionAvailability enAvailGrassland { get; private set; }

    #endregion


    #region Functions

    public Grassland() : base()
    {

    }

    public Grassland(Sprite[] aSprite, Dictionary<ResourceList, int> aResources, string aName, MoveRange aRange, ExpeditionAvailability aAvail) 
        : base(aSprite, aResources, aName, aRange, aAvail)
    {
        //Inherited and overriding the base constructor with appropriate info
        this.sprSpriteGrassland = aSprite;
        this.dResourcesGrassland = aResources;
        this.sNameGrassland = aName;
        this.enRangeGrassland = aRange;
        this.enAvailGrassland = aAvail;
    }


    #endregion
}
