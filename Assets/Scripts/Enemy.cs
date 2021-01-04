using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;
    [SerializeField] GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        transform.Rotate(0,0,speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
            GameManager.instance.GameOver();

        }else if(other.gameObject.tag == "Ground"){
            GameManager.instance.IncrementScore();
            gameObject.SetActive(false);
            GameObject dustEffect =  Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(dustEffect, 2f);
             Destroy(gameObject, 3f);
        }
    }
}
