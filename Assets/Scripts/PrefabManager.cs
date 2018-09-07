using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script should be an a empty gameobject somewhere in the scene
// DontDestroyOnLoad would be great (like for the most manager)

public class PrefabManager : MonoBehaviour
{
    // Assign the prefab in the inspector
    public GameObject cubePrefab;

    // Position where to instantiate prefab
    private Transform position;

    //Singleton
    private static PrefabManager m_Instance = null;
    public static PrefabManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = (PrefabManager)FindObjectOfType(typeof(PrefabManager));
            }
            return m_Instance;
        }
    }

    private void Start()
    {
        position = GameObject.Find("instantiateHere").transform;
        Instantiate(PrefabManager.Instance.cubePrefab, position.position, Quaternion.identity);
    }
}