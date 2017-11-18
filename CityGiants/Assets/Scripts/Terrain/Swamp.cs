using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: November 10th, 2017
 * Updated: November 10th, 2017
 * 
 * Description: Inherits from LandTerrain, used for the specific terrain effects
 * 
 * 
 */

public class Swamp : LandTerrain {
   
    #region Functions

    public Swamp()
    {
        AssignID(5);
        AssignName("Swamp");
        Sprite tempSpr = null;
        AssignSprite(tempSpr);
        AssignMoveRange(MoveRange.Long);
        AssignExpedition(ExpeditionAvailability.Low);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.Hunt, 1);
        tempDict.Add(ResourceList.Fish, 1);
        tempDict.Add(ResourceList.WildProduce, 1);
        AssignDictionary(tempDict);
    }

    public Swamp(Sprite pSpr)
    {
        AssignID(5);
        AssignName("Swamp");
        AssignSprite(pSpr);
        AssignMoveRange(MoveRange.Long);
        AssignExpedition(ExpeditionAvailability.Low);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.Hunt, 1);
        tempDict.Add(ResourceList.Fish, 1);
        tempDict.Add(ResourceList.WildProduce, 1);
        AssignDictionary(tempDict);
    }

    #endregion
}
