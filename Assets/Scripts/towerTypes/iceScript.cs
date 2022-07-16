using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceScript : MonoBehaviour
{
    public storeTowerType tower;

    //void Start()
    //{
    //    FindController();
    //}
 
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("ground"))
        {
            tower.turretType = 2;
            tower.isTurretAvailable = true;
        }
    }

    //void FindController()
    //{
    //    GameObject tower = GameObject.Find("GameController");
    //}

    void Awake()
    {
        tower = FindObjectOfType<storeTowerType>();
    }
}
