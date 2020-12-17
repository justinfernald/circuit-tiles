using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TileGrid : MonoBehaviour
{
    public int tileSize = 100; // in pixel size
    public GameObject tileObject;

    void Start()
    {
        foreach (Transform child in transform)
        {
            Debug.Log("a child");
            if (!Application.isPlaying)
            {
                Debug.Log("not playing");
                GameObject.DestroyImmediate(child.gameObject);
            }
            else
            {
                Debug.Log("playing");
                //GameObject.Destroy(child.gameObject);
            }
        }

        //for (int i = -9; i < 10; i++)
        //{
        //    for (int j = -9; j < 10; j++)
        //    {
        //        Instantiate(tileObject, new Vector3(i, j, 0), Quaternion.identity, transform);
        //    }
        //}
        if (!Application.isPlaying)
            Instantiate(tileObject, new Vector3(0, 0, 0), Quaternion.identity, transform);
    }

    void Update()
    {

    }
}
