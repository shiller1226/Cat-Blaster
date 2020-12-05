using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    public Animator animator;
    public int health = 6;
    private Rigidbody2D rb;
    public Text healthDisplay;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {

        // healthDisplay.text = "HEALTH :" + health;
        
        if(health <= 0){
            Debug.Log("dead");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        
        transform.position = transform.position + movement * Time.deltaTime;

    }
}
