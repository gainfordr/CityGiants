using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* **********************************************************
 * Author: Jared Rosenberger
 * Created: September 3rd, 2017
 * Updated: November 10th, 2017
 * 
 * Description: Inherits from LandTerrain, used for the specific terrain type
 * 
 * 
 */

public class Forest : LandTerrain {


    #region Functions

    public Forest()
    {
        AssignID(0);
        AssignName("Forest");
        Sprite tempSpr = null;
        AssignSprite(tempSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();

        tempDict.Add(ResourceList.Wood, 1);
        tempDict.Add(ResourceList.Hunt, 1);
        tempDict.Add(ResourceList.WildProduce, 1);

        AssignDictionary(tempDict);
        AssignMoveRange(MoveRange.Average);
        AssignExpedition(ExpeditionAvailability.Average);
    }

    public Forest(Sprite pSpr)
    {
        AssignID(0);
        AssignName("Forest");
        AssignSprite(pSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();

        tempDict.Add(ResourceList.Wood, 1);
        tempDict.Add(ResourceList.Hunt, 1);
        tempDict.Add(ResourceList.WildProduce, 1);

        AssignDictionary(tempDict);
        AssignMoveRange(MoveRange.Average);
        AssignExpedition(ExpeditionAvailability.Average);
    }

    #endregion
}
