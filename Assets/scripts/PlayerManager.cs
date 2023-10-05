using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton

    public static PlayerManager instance;

    void awake ()
    {
        instance = this;
    }

    public GameObject player;
    #endregion 


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
