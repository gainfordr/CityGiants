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

public class Desert : LandTerrain {

    #region Functions

    public Desert(Sprite pSpr)
    {
        AssignID(4);
        AssignName("Desert");
        AssignSprite(pSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();

        tempDict.Add(ResourceList.None, 0);

        AssignDictionary(tempDict);
        AssignMoveRange(MoveRange.Short);
        AssignExpedition(ExpeditionAvailability.Extreme);
    }

    #endregion
}
