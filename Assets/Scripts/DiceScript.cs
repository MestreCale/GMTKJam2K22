using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{

    public Component[] sides;

    public int totalsides;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Random.rotation;
        StartCoroutine(diceDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator diceDelay()
    {
        yield return new WaitForSeconds(3);
        WhatSideUp();
    }

    void WhatSideUp()
    {
        //sides = GetComponentsInChildren<side>();

        //foreach (side side in sides)
        //{
        //    totalsides + 1;
        //}
    }
}
