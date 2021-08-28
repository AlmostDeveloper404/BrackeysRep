using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : Spawner
{
    #region Singleton
    public static HumanSpawner instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than ine instance!");
            return;
        }
        instance = this;
    }

    #endregion
}
