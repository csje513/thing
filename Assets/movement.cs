using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject camera;
    public GameObject winScreen;
    public bool canMove = true;
    private int a;
    public int b;
    public float speed;
    private Rigidbody2D rb;
    public bool grounded = true;
    public void MoveLeft(){
        // transform.position += new Vector3(1,0,0);
        if(canMove && Mathf.Abs(rb.velocity.x) < speed){
            
            rb.AddForce(new Vector3(-1,0,0), ForceMode2D.Impulse);
        }
    }
    public void MoveRight(){
        // transform.position += new Vector3(-1,0,0);
        Debug.Log(rb.velocity.magnitude);
        if(canMove && Mathf.Abs(rb.velocity.x) < speed){
            rb.AddForce(new Vector3(1,0,0), ForceMode2D.Impulse);
        }
    }
    public void MoveJump(){
        if(canMove){
            if (grounded){
                rb.AddForce(new Vector3(0,5,0), ForceMode2D.Impulse);
                grounded = false;
            }
        }

    }
    // start is called before the first frame update
    // this variable determines the speed of the square
    // 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // update is called once per frame
    void Update()
    {
        if(canMove && Mathf.Abs(rb.velocity.x) <= speed){
            rb.AddForce(new Vector3(Input.GetAxisRaw("Horizontal")*10, 0, 0), ForceMode2D.Force);
        } else if (canMove) {
            if (rb.velocity.x < 0){
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            } else {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }
            
        }
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);

        if(Input.GetKeyDown("space")||Input.GetKeyDown(KeyCode.UpArrow)){
            MoveJump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            grounded = true; 
        }
        
        if (collision.gameObject.CompareTag("Finish Line")) {
            winScreen.SetActive(true);
            canMove = false;
        }
       
    }
}
