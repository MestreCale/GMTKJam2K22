using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceThrow : MonoBehaviour
{
    public GameObject dice;


    // Start is called before the first frame update
    void Start()
    {
        spawnDie();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnDie()
    {
        Vector3 spawnPos = new Vector3(1, 2, -4);
        Instantiate(dice, spawnPos, Quaternion.identity);
    }
}
