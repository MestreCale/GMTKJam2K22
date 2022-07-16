using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public bool isTurretAvailable = false;
    public int turretType;

    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Random.rotation;
        StartCoroutine(DiceDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DiceDelay()
    {
        yield return new WaitForSeconds(3);
    }


}
