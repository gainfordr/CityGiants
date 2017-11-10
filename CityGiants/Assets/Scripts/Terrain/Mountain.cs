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

public class Mountain : LandTerrain {
    
    #region Functions

    public Mountain(Sprite pSpr)
    {
        AssignID(5);
        AssignName("Mountain");
        AssignSprite(pSpr);
        AssignMoveRange(MoveRange.Long);
        AssignExpedition(ExpeditionAvailability.Average);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.Hunt, 1);
        tempDict.Add(ResourceList.Mine, 1);
        AssignDictionary(tempDict);
    }

    #endregion
}
