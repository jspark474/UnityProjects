using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILoader<Key, Value>
{
    Dictionary<Key, Value> MakeDict();
}

public class DataManager 
{
    public Dictionary<int, Stat> StatDict { get; private set; } = new Dictionary<int, Stat>();

    public void Init()
    {
        StatDict = loadjson<StatData, int, Stat>("StatData").MakeDict();
    }

    Loader loadjson<Loader, Key, Value>(string path) where Loader : ILoader<Key, Value>
    {
        TextAsset textasset = Managers.Resource.Load<TextAsset>($"data/{path}");
        return JsonUtility.FromJson<Loader>(textasset.text);
    }
}
