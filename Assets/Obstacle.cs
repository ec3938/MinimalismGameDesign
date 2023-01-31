using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{  

    public int damage = 1;
    public float speed;

    public GameObject effect;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")) {
            //camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            //player takes damage
            other.gameObject.GetComponent<Player>().health -= damage;
            Debug.Log(other.gameObject.GetComponent<Player>().health);
            Destroy(gameObject);

            HealthManager.instance.DamageHealth();
        }
    }

    void Start(){
        Destroy(gameObject, 10f);
    }
}
