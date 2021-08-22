using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorOpen : MonoBehaviour
{ public Animation openAnim;
    public Text message;
    public GameObject message_window;
    public AudioSource warningSound;
    public AudioSource winsound;
    private bool keypressed=false;
    private bool dooropen = false;
    private void OnTriggerStay(Collider other)
    {
        message_window.SetActive(true);
        if (keypressed==true)
        {
            
            if (other.gameObject.tag == "Player" && GameManager.instance.keycollected == GameManager.instance.totalCollected)
            {
                winsound.Play();
                message.text = "Walk through the gateway...";
                openAnim.Play();
                dooropen = true;
            }
            if (GameManager.instance.keycollected < GameManager.instance.totalCollected)
            {
                message.text = "Not Enough Keys???";
                warningSound.Play();

            }
            keypressed = false;
        }
           
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "Press E To Open The Door..";
        message_window.SetActive(false);
        if (dooropen == true)
        {
            message.text = "Walk through the gateway...";
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            keypressed = true;
        }
        else
        {
            keypressed = false;
        }
    }
}
