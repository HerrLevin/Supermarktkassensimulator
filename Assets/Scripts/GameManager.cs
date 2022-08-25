using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool stopRightConveyer = false;

    void Awake()
    {
        instance = this;
    }
}
