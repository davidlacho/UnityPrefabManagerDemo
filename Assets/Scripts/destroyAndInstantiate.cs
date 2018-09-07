using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAndInstantiate : MonoBehaviour {

    // Position where to instantiate prefab
    public Transform position;


	private void Start()
	{
        position = GameObject.Find("instantiateHere").transform;
	}
	void OnMouseDown()
    {
        Instantiate(PrefabManager.Instance.cubePrefab, position.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
