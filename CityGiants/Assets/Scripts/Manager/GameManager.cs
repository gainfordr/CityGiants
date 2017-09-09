using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Member Variables

    public static GameManager Instance = null;
    private GameObject parentBuildings; 

    #endregion

    // Making sure Game Manager is the first thing that happens at the start of the game
    void Awake()
    {

        // Will create instance, ensure only one exists
        // Will also make sure it cant be destroyed
        // Call Setup function to setup all the managers

        // Also grabs parent object of all the buildings in the game to go through child objects

    }

    void SetUpManagers()
    {

        // This function initiates all managers
        // They will need to be adjusted to create singletons of themselves
        // Will also need to setup initial game mechanics
        // Two possibilities:

        // A) Make all managers inherit from Manager base class and then add to generic list

        // B) Add each manager individually to Game Manager

    }

    void Update ()
    {

        // Will have a while loop to check that the current player's turn is still going
        // Will wait for the end of turn button to be pushed then goes thorugh end of turn logic
		
	}

    public void EndTurn()
    {

        // Here all the End of turn logic will happen

        // Will call all building's end of turn functions

    }

}
