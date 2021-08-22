using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject spawnPoint;
    int speed=5;
    public GameObject projectilePrefab;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Shoot", 0f, 3f);

    }

    // Update is called once per frame
    public void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
       
    }


       
        
    
}
