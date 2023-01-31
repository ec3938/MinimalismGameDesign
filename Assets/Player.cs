using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement;
    public float speed;
    public float maxX;
    public float minX;

    public int health = 3; //can change to 1 for instant death
    //public Animator canAnim;

    void Start()
    {
        transform.position = new Vector3(-3, 0,0);
        targetPos = new Vector2(-3,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            SceneManager.LoadScene("GameOver");
        }

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.x < maxX) { //left side -> right side
            //camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y); //moves char left/right 5
        } 
        else if (Input.GetKeyDown(KeyCode.Space) && transform.position.x > minX) { //right side -> left side
            //camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    }
    //make player bigger as time goes on
}
