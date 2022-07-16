using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{

    
    [Header("Dice Properties")]
   [SerializeField] private int diceNumber;
    

    public int DiceNumber
   {
       get => diceNumber;
       set => diceNumber = value;
   }
   
  
}
