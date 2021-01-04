using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float xInput = 1;
    public float moveSpeed;
    Vector2 position;
   float screenCenterX;
   [SerializeField] float xPositionLimit;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        screenCenterX = Screen.width * 0.5f;
       
    }

    // Update is called once per frame
    void Update()
    {
         
         // if there are any touches currently
       
    }

    private void FixedUpdate() {
        MovePlayer();
    }

    void MovePlayer(){
        position = transform.position;
         if(Input.GetMouseButtonDown(0))
        {
            if(Input.mousePosition.x > screenCenterX){
                   position.x += xInput * moveSpeed;
                   position.x = Mathf.Clamp(position.x, -xPositionLimit, xPositionLimit);
                   rb.MovePosition(position);
            }else if(Input.mousePosition.x < screenCenterX){
                   position.x -= xInput * moveSpeed;
                   position.x = Mathf.Clamp(position.x, -xPositionLimit, xPositionLimit);
                   rb.MovePosition(position);
            }
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)){
            xInput = Input.GetAxis("Horizontal");
            position.x += xInput * moveSpeed;
            position.x = Mathf.Clamp(position.x, -xPositionLimit, xPositionLimit);
            rb.MovePosition(position);
        }
    }
}
