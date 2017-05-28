using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore_Collect : MonoBehaviour {

    public TextMesh tm;
    private int ore_count = 0;
    public Transform ore_holder;


    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ore" && ore_count < 20)
        { 
            c.transform.parent = ore_holder;
            c.gameObject.layer = 9;
            ore_count++;
            tm.text = "Items: " + ore_count + "/" + 20;
        }
        else
        {
            c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(3.5f, 4f), Random.Range(-1.5f, -2f));
        }
    }
}
