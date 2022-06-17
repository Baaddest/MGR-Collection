using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveAndLoadMGR : MonoBehaviour
{
    public PlayerVarMGR userInfo;
    public Data user;

    public void start()
    {
        user = userInfo.userVars;
        user.stringToSave1 = Load().stringToSave1;
        user.stringToSave2 = Load().stringToSave2;
        user.stringToSave3 = Load().stringToSave3;

        user.intToSave1 = Load().intToSave1;
        user.intToSave2 = Load().intToSave2;
        user.intToSave3 = Load().intToSave3;
    }
    public void save()
    {
        userInfo.RefreshAtros();
        string thisSave = JsonUtility.ToJson(user);
        File.WriteAllText(Application.dataPath + "/userData/User.json", thisSave);
    }
    Data Load()
    {
        string loadInfo = File.ReadAllText(Application.dataPath + "/userData/User.json");
        return JsonUtility.FromJson<Data>(loadInfo);
    }
}
