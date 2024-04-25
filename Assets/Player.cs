using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float movementSpeedCap;
    public KeyCode jumpKey;
    
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        if(Input.GetKeyDown(jumpKey)){
            //transform.Translate(0,jumpForce,0 * Time.deltaTime);
            if(Input.GetKeyDown(jumpKey)){
                rb.velocity = Vector3.zero;
                rb.AddForce(new Vector2(0, jumpForce) * Time.deltaTime, ForceMode2D.Impulse);
                rb.velocity = rb.velocity.normalized * movementSpeedCap;
                
            }
        }
  
    }  
}
