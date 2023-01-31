using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    public Text healthText;
    public int health=3;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();

    }
    public void DamageHealth(){
        health-=1;
        healthText.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
