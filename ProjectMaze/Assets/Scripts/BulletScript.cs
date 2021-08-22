using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroybullet());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    IEnumerator Destroybullet()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }

}
