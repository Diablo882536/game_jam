using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    
  public float speed;
    Rigidbody2D rg2d;

    Animator anim;

    SpriteRenderer thesr;
    public int jumpSpeed;
   public  Transform scale; 

    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        thesr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rg2d.velocity = new Vector2 (speed * Input.GetAxis("Horizontal"), rg2d.velocity.y);


        FlipSprite(); 
      //  anim.SetFloat("isrun", Mathf.Abs(rg2d.velocity.x ));
         
         if(Input.GetButtonDown("Jump")){ 
       
       
        {
            rg2d.velocity = new Vector2(rg2d.velocity.x , jumpSpeed );
               
        } 


    }
    }

     void FlipSprite()
    {
        bool playerHasHorizontalSpeed = Mathf.Abs(rg2d.velocity.x) > Mathf.Epsilon;

        if (playerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2 (Mathf.Sign(rg2d.velocity.x), 1f);
        }
    } 

   
}
