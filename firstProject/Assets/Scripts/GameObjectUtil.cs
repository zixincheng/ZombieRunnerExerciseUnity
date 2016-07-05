using UnityEngine;
using System.Collections;

public class GameObjectUtil : MonoBehaviour {

	// Use this for initialization
    public static GameObject Instantiate(GameObject prefab, Vector3 pos)
    {
        GameObject instance = null;

        instance = GameObject.Instantiate(prefab);
        instance.transform.position = pos;
        return instance;

    }

    public static void Destroy(GameObject prefab)
    {

        GameObject.Destroy(prefab);
    }
}
