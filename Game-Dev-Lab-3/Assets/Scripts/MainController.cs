using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        GameObject[] chairs = GameObject.FindGameObjectsWithTag("chair");
        System.Random rand = new System.Random();
        List<GameObject> toDestroy = new List<GameObject>();

        for (int i = 0; i < 50; i++)
        {
            int index = rand.Next(chairs.Length);
            if (toDestroy.Contains(chairs[index]))
            {
                i--;
            }
            else
            {
                toDestroy.Add(chairs[index]);
            }
        }

        foreach (GameObject chair in toDestroy) {
            Destroy(chair);
            Debug.Log("destroy");
            Debug.Log(chair);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
