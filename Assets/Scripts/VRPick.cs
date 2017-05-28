using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRPick : VRTK_InteractableObject
{
    int count = 0;
    public override void StartUsing(GameObject currentUsingObject)
    {
        base.StartUsing(currentUsingObject);
        print("Hello");
    }


    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Ore_Vein")
        {
            c.GetComponent<Ore_Controller>().hit(5);
        }
    }

}
