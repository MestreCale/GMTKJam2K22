using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public Vector3 currentPos;
    public Vector3 targetPos;
    public int pathNumber = 1;

    float speed = 1;

    public GameObject target;



    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("path (" + pathNumber + ")");
        currentPos = transform.position;
        targetPos = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Path")
        {
            Debug.Log("H‰‰llollaa");
            pathNumber = pathNumber + 1;
            target = GameObject.Find("path (" + pathNumber + ")");
            targetPos = target.transform.position;
        }
            
    }
}
