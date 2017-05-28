using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Home_Button : VRTK_DestinationMarker
{ 
    public Transform destination, offset_loc;   
    private bool lastUsePressedState = false;

    private void OnTriggerStay(Collider collider)
    {
        var controller = (collider.GetComponent<VRTK_ControllerEvents>() ? collider.GetComponent<VRTK_ControllerEvents>() : collider.GetComponentInParent<VRTK_ControllerEvents>());
        if (controller)
        {
            if (lastUsePressedState == true && !controller.usePressed)
            {
                var distance = Vector3.Distance(transform.position, destination.position);
                var controllerIndex = VRTK_DeviceFinder.GetControllerIndex(controller.gameObject);
                OnDestinationMarkerSet(SetDestinationMarkerEvent(distance, destination, new RaycastHit(), destination.position, controllerIndex));
            }
            lastUsePressedState = controller.usePressed;
        }
    }
}
