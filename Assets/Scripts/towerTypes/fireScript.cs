using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireScript : MonoBehaviour
{

    public storeTowerType tower;



    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("ground"))
        {
            tower.turretType = 0;
            tower.isTurretAvailable = true;
        }
    }
    void Awake()
    {
        tower = FindObjectOfType<storeTowerType>();
    }
}
