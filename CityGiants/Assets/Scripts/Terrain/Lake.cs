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

public class Lake : LandTerrain {

    #region Functions

    public Lake(Sprite pSpr)
    {
        AssignID(2);
        AssignName("Lake");
        AssignSprite(pSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.Fish, 1);

        AssignDictionary(tempDict);
   
        AssignMoveRange(MoveRange.Average);
        AssignExpedition(ExpeditionAvailability.Low);
    }

    #endregion
}
