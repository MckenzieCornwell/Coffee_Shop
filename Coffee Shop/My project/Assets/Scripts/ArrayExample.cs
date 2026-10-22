using UnityEngine;
using System.Collections.Generic;

public class ArrayExample : MonoBehaviour
{
    public GameObject[] GameObject;

    public List<GameObject> gameObjectsList = new List<GameObject>();

    void Start()
    {
        foreach (GameObject obj in gameObjectsList)
        {
            Debug.Log("GameObject in List: " + obj.name);
        }
    }
}
