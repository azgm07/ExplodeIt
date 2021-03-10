using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    private static GameController m_instance;
    public event Action<GameObject> OnExplodeObject;
    public event Action<GameObject> OnDestroyObject;

    public static GameController Instance { get=> m_instance ; private set=> m_instance = value;}
    
    private void Awake() {
        Instance = this;
    }

    public void Explode(GameObject go)
    {
        OnExplodeObject.Invoke(go);
    }
    // public void Destroy(GameObject go)
    // {
    //     OnDestroyObject.Invoke(go);
    // }
}
