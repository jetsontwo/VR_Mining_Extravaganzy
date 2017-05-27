using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore_Collect : MonoBehaviour {

    private GameObject[] ores;
    private int ore_count = 0;

    void Start()
    {
        ores = new GameObject[20];
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ore" && ore_count < ores.Length - 1)
        {
            ores[ore_count++] = c.gameObject;
            c.gameObject.SetActive(false);
        }
    }
}
