using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//this will go onto your player and hold the different atrabutes that the player will have
[Serializable]
public class Data
{
     public string stringToSave1, stringToSave2, stringToSave3;
     public int intToSave1, intToSave2, intToSave3;

    public Data()
    {
        this.stringToSave1 = stringToSave1;
        this.stringToSave2 = stringToSave2;
        this.stringToSave3 = stringToSave3;

        this.intToSave1 = intToSave1;
        this.intToSave2 = intToSave2;
        this.intToSave3 = intToSave3;
    }
}

public class PlayerVarMGR : MonoBehaviour
{
    public Data userVars;
    public SaveAndLoadMGR SAL;

    public void SaveEverything()
    {
        SAL.save();
    }
    public void RefreshAtros()
    {
        SAL.user = this.userVars;
    }
    public void SavedInt1()
    {
        switch(userVars.intToSave1)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
    public void SavedInt2()
    {
        switch (userVars.intToSave2)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
    public void SavedInt3()
    {
        switch (userVars.intToSave3)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}

