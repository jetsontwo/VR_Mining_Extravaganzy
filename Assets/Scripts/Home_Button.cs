using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_Button : MonoBehaviour {

    void OnTriggerEnter(Collider c)
    {
        print("yo");
        print(c.tag);
    }
}
