using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore_Collect : MonoBehaviour {

    private GameObject[] ores;
    private int ore_count = 0;

    void Start()
    {
        ores = new GameObject[5];
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ore" && ore_count < ores.Length)
        {
            ores[ore_count++] = c.gameObject;
            c.gameObject.SetActive(false);
        }
        else
        {
            c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(3.5f, 4f), Random.Range(-1.5f, -2f));
        }
    }
}
