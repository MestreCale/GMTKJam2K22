using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class turretShoot : MonoBehaviour
{

    public GameObject projectile;

    public float launchVelocity = 50f;
    public bool roundActive = false;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    public Vector3 enemyPos;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (roundActive == true && Time.time > nextFire)
        {


            enemyPos = FindClosestEnemy().transform.position;

            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(enemyPos * launchVelocity);
            nextFire = Time.time + fireRate;
        }
    }



    public GameObject FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            return null;
        }
        GameObject closest;
        if (enemies.Length == 1)
        {
            closest = enemies[0];
            return closest;
        }

        closest = enemies.OrderBy(go => (transform.position - go.transform.position).sqrMagnitude).First();
        Debug.Log("targetting" + closest.transform.position);
        return closest;
    }

    void TypeOfTower()
    {

    }
}
