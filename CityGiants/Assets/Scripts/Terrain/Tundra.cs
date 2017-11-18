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

public class Tundra : LandTerrain {

    #region Functions

    public Tundra()
    {
        AssignID(6);
        AssignName("Tundra");
        Sprite tempSpr = null;
        AssignSprite(tempSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();

        tempDict.Add(ResourceList.Hunt, 1);

        AssignDictionary(tempDict);
        AssignMoveRange(MoveRange.Short);
        AssignExpedition(ExpeditionAvailability.High);
    }

    public Tundra(Sprite pSpr)
    {
        AssignID(6);
        AssignName("Tundra");
        AssignSprite(pSpr);
        Dictionary<ResourceList, int> tempDict = new Dictionary<ResourceList, int>();

        tempDict.Add(ResourceList.Hunt, 1);

        AssignDictionary(tempDict);
        AssignMoveRange(MoveRange.Short);
        AssignExpedition(ExpeditionAvailability.High);
    }

    #endregion

}
