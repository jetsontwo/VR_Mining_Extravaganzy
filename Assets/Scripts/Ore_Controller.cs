using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore_Controller : MonoBehaviour {


    public float damage_needed;
    public GameObject ore;
    private float cur_damage;
    public void hit(float damage)
    {
        cur_damage += damage;

        if(cur_damage >= damage_needed)
        {
            cur_damage = 0;
            Instantiate(ore, new Vector3(transform.position.x + Random.Range(0.4f, 0.5f), transform.position.y + Random.Range(0.3f, 0.6f), transform.position.z + Random.Range(-0.4f, 0.4f)), Quaternion.identity);
        }
    }


}
