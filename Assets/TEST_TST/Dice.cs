using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Dice : MonoBehaviour
{
    private TowerController _towerController;


    private void Awake()
    {
        _towerController = FindObjectOfType<TowerController>();

    }

    

    private void RollDice()
    {
        int randomNumber = UnityEngine.Random.Range(0, 6);
        _towerController.DiceNumber = randomNumber;
    }
}
