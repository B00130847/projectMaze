using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int keycollected;
    public int totalCollected;
    public Text keyText;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance != null)
        { 
            Destroy(gameObject);
            
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { keyText.text = keycollected.ToString();
        if(keycollected== totalCollected)
        {
            Debug.Log("Game win01");
        }
    }
}
