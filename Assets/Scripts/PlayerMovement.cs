using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
   public float MoveSpeed;
   public Rigidbody2D rb;
   private Vector2 moveDirection;
   //--------------
   //public int maxHealth= 100;
   //public int currentHealth;
   //public HealthBar healthBar;
   //--------------
  /*   void Start(){
        currentHealth= maxHealth;
        healthBar.SetMaxHealth(maxHealth);
     }*/
    void Update()
    {
      ProcessInputs();  

     // if(Input.GetKeyDown(KeyCode.Space)){
     //   TakeDamage(20);
     // }

    }

    /*void TakeDamage(int damage){
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);
    }*/

     private void FixedUpdate() {
      Move();  
     }

     void ProcessInputs(){
      float moveX = Input.GetAxisRaw("Horizontal");
      float moveY = Input.GetAxisRaw("Vertical");
      moveDirection = new Vector2(moveX, moveY).normalized;
     }

     void Move(){
      rb.velocity= new Vector2(moveDirection.x * MoveSpeed, moveDirection.y*MoveSpeed);
     }


}
