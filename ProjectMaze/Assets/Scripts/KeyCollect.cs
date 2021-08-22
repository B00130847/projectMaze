using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    public AudioSource keyCollected;
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            keyCollected. Play();
            GameManager.instance.keycollected += 1;
            Destroy(gameObject);
        }
    }
}
