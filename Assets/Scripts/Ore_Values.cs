using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Ore_Values : MonoBehaviour {

    public float value;
    public VRTK_InteractableObject io;

    void OnTriggerStay(Collider c)
    {
        if (gameObject.layer == 9)
        {
            if (io.enabled)
            {
                RaycastHit rh;
                Physics.Raycast(transform.position, Vector3.forward, out rh, 0.01f);
                print(rh.collider);

                //If still colliding with inside of thing then do nothing
                //Once its out of collision then deduct from cart count and reset layer
                if (rh.collider)
                    print(rh.collider.gameObject);
                //else
                    //gameObject.layer = 0;

                //Raycast here to see if it still inside cart
            }
        }
    }
}
