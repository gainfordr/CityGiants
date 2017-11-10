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

public class Wasteland :LandTerrain {

    #region Functions

    public Wasteland(Sprite pSpr)
    {
        AssignID(8);
        AssignName("Wasteland");
        AssignSprite(pSpr);
        AssignMoveRange(MoveRange.Short);
        AssignExpedition(ExpeditionAvailability.High);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();
        tempDict.Add(ResourceList.None, 0);
        AssignDictionary(tempDict);
    }

    #endregion
}
