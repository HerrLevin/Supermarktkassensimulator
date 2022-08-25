using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightConveyerStopper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.stopRightConveyer = true;
    }

    private void OnTriggerStay(Collider other)
    {
        GameManager.instance.stopRightConveyer = true;
    }

    private void OnTriggerExit(Collider other)
    {
        GameManager.instance.stopRightConveyer = false;
    }
}
