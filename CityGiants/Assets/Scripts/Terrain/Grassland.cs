using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: November 10th, 2017
 * 
 * Description: Inherits from LandTerrain, used for the specific terrain effects
 * 
 * 
 */

public class Grassland : LandTerrain {

    #region Functions

    public Grassland()
    {
        AssignID(1);
        AssignName("Grassland");
        Sprite tempSpr = null;
        AssignSprite(tempSpr);
        AssignMoveRange(MoveRange.Short);
        AssignExpedition(ExpeditionAvailability.High);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.Hunt, 1);
        AssignDictionary(tempDict);
    }

    public Grassland(Sprite pSpr) 
    {
        AssignID(1);
        AssignName("Grassland");
        AssignSprite(pSpr);
        AssignMoveRange(MoveRange.Short);
        AssignExpedition(ExpeditionAvailability.High);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.Hunt, 1);
        AssignDictionary(tempDict);
    }

    #endregion
}
