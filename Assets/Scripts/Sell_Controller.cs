using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell_Controller : MonoBehaviour {

    public float money = 0;
    public TextMesh tm;

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Ore")
        {
            money += c.gameObject.GetComponent<Ore_Values>().value;
            tm.text = "Money: " + money;
            Destroy(c.gameObject);
        }
        else
        {
            c.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-2f, 2f), Random.Range(-4f, 4f), Random.Range(-2f, 2f));
        }
    }
}
