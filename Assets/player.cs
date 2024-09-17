using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 500.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 100;
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    
 

    // Update is called once per frame
    void Update()
    {
        
        

            if (Input.GetMouseButtonDown(0) &&
            this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

       
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
    
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
      
        
    }
  
        void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("ƒS[ƒ‹");
            SceneManager.LoadScene("Game Kuria");
        }
}
