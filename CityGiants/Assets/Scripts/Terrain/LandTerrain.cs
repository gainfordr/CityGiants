using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: November 10th, 2017
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

public enum ResourceList
{
    /*
        Wood, 
        Food_Hunt,
        Food_WildProduce,
        Food_Fish,
        Mine

     */

    Wood,
    Hunt,
    WildProduce,
    Fish,
    Mine,
    None
}

public class LandTerrain {

    #region Member Variables

    public int iId { get; private set; }
    public string sName { get; private set; }
    public Sprite sprSprite { get; private set; }
    public Dictionary<ResourceList, int> dResources { get; private set; }
    public MoveRange enRange { get; private set; }
    public ExpeditionAvailability enAvail { get; private set; }

    #endregion

    #region Member Function
    public LandTerrain()
    {
        // Base constructor, to be inherited and overriden by the specific weather types
        this.iId = -1;
        this.sprSprite = null;
        this.dResources = null;
        this.sName = null;
        this.enRange = MoveRange.Short;
        this.enAvail = ExpeditionAvailability.Low;
    }

    public virtual void AssignID(int pId) { this.iId = pId; }
    public virtual void AssignName(string pName) { this.sName = pName; }
    public virtual void AssignSprite(Sprite pSpr) { this.sprSprite = pSpr; }
    public virtual void AssignDictionary(Dictionary<ResourceList, int> pDict) { this.dResources = pDict; }
    public virtual void AssignMoveRange(MoveRange pRange) { this.enRange = pRange; }
    public virtual void AssignExpedition(ExpeditionAvailability pExpedAvail) { this.enAvail = pExpedAvail; }

    #endregion 
}
