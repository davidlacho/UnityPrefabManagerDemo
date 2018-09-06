using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAndInstantiate : MonoBehaviour {

    void OnMouseDown()
    {
        Instantiate(PrefabManager.Instance.cubePrefab);
        Destroy(gameObject);
    }

}
