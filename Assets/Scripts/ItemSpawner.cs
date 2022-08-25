using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    private float timer = 2;
    public GameObject[] groceryItems;
    private int randomIndex;


    private bool TimerFinished()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = Random.Range(0.25f, 2.0f);
            return true;
        }

        return false;
    }
    
    void Update()
    {
        if (TimerFinished())
        {
            randomIndex = Random.Range(0, groceryItems.Length);
            Instantiate(groceryItems[randomIndex], transform.position, groceryItems[randomIndex].transform.rotation);
        }
    }
}
