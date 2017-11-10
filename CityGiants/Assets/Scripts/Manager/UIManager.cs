using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIManager : MonoBehaviour {

    #region Member Variables

    public Canvas cCurrentCanvas { get; private set; }
    public Canvas cPreviousCanvas { get; private set; }
    public List<BaseMenu> lMenuList { get; private set; }
    public Text tFoodText { get; private set; }
    public Text tWoodText { get; private set; }
    public Text tMineText { get; private set; }

    #endregion


    #region Functions

    void Awake()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Will be used to check for end of turn and apply end of turn effects
        UpdateStats();
	}

    public void SetupManagers()
    {
        InitMenus();
        SwitchMenu(lMenuList[0].cMenu);
    }

    public void InitMenus()
    {
        lMenuList = new List<BaseMenu>();
    }

    public void SwitchMenu(Canvas aNewMenu)
    {
        //Switches menu based on the canvas given to it
        cPreviousCanvas = cCurrentCanvas;
        cCurrentCanvas = aNewMenu;
    }

    public void SendString(string aString)
    {
        //Will send a string to a specific manager
    }

    public void SendInt(int aInt)
    {
        //Will send a int to a specific manager
    }

    public void UpdateStats()
    {
        //Will constantly be keeping track of the menu items for the bar
    }

    public void EndOfTurn()
    {
        //Will deal with UI end of turn specific details
    }

    #endregion 
}
