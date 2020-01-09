using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateStatDataClass
{
    [MenuItem("Assets/Date/CloudData")]
    public static CloudData CreateStatData()
    {
        CloudData asset = ScriptableObject.CreateInstance<CloudData>();
        AssetDatabase.CreateAsset(asset, "Assets/Editor/Data/CloudData.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    [MenuItem("Assets/Date/CreatureData")]
    public static CreatureData CreateCreatureData()
    {
        CreatureData asset = ScriptableObject.CreateInstance<CreatureData>();
        AssetDatabase.CreateAsset(asset, "Assets/Editor/Data/Creature.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    /*
    [MenuItem("Assets/Date/**Data")]
    public static CreatureData Create**Data()
    {
        **Data asset = ScriptableObject.CreateInstance<**Data>();
        AssetDatabase.CreateAsset(asset, "Assets/Editor/Data/**.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }
    */

}
