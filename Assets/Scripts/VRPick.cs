using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRPick : VRTK_InteractableObject
{

    public override void StartUsing(GameObject currentUsingObject)
    {
        base.StartUsing(currentUsingObject);
        print("Hello");
    }

}
