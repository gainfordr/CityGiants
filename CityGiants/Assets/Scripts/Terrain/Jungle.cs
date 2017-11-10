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

public class Jungle : LandTerrain {

    #region Functions

    public Jungle(Sprite pSpr)
    {
        AssignID(7);
        AssignName("Jungle");
        AssignSprite(pSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();

        tempDict.Add(ResourceList.Wood, 1);
        tempDict.Add(ResourceList.Hunt, 1);
        tempDict.Add(ResourceList.WildProduce, 1);

        AssignDictionary(tempDict);
        AssignMoveRange(MoveRange.Long);
        AssignExpedition(ExpeditionAvailability.Extreme);
    }

    #endregion
}
