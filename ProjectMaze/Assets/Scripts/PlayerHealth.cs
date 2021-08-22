using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public int maxHealthValue=100;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        
        currentHealth = maxHealthValue;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = maxHealthValue;
        if (maxHealthValue <= 0)
        {
            Debug.Log("losse");
            SceneManager.LoadScene("GameOver");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            maxHealthValue -=10;
        }
    }
}
