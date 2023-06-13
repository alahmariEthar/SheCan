using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIntracts : MonoBehaviour
{
      public int maxHealth= 100;
       public int maxHealthDisk= 100;
       public int minHealthBaby= 0;

      public int currentHealth;
      public int currentHealthDisk;
      public int currentHealthBaby;

      public HealthBar healthBar;
      public HealthDisk healthBarDisk;
      public HealthBaby healthBaby;
  
    //--------
   bool triggerKitchen = false;
      bool triggerDisk = false;
      bool triggerBaby = false;
   //-----------------
     void Start(){
        currentHealth= maxHealth;
        currentHealthDisk=maxHealthDisk;
        currentHealthBaby=minHealthBaby;

        healthBar.SetMaxHealth(maxHealth);
       healthBarDisk.SetMaxHealth(maxHealthDisk);
       healthBaby.SetMinHealth(minHealthBaby);
     }

     
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space)&& triggerKitchen){
        TakeDamage(20);
      }

       if(Input.GetKeyDown(KeyCode.Space)&& triggerDisk){
        TakeDamageDisk(20);
      }

      if(Input.GetKeyDown(KeyCode.Space)&& triggerBaby){
        TakeDamageBaby(20);
      }

    }

    void TakeDamage(int damage){
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);
    }

    void TakeDamageDisk(int damage){
        currentHealthDisk -=damage;
       healthBarDisk.SetHealth(currentHealthDisk);
    }
    void TakeDamageBaby(int damage){
        currentHealthBaby +=damage;
       healthBaby.SetHealth(currentHealthBaby);
    }
    
     private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Kitchen"))
        {
          triggerKitchen=true;
             Debug.Log("inter kitchen");
        } 


        if (other.gameObject.CompareTag("Disk"))
        {
             triggerDisk=true;
             Debug.Log("inter disk");
        } 

         if (other.gameObject.CompareTag("Baby"))
        {
             triggerBaby=true;
             Debug.Log("inter baby zone");
        } 


        }
     //-----------------------------------------------------
         private void OnTriggerExit2D(Collider2D other)
        {
        if (other.gameObject.CompareTag("Kitchen"))
        {
           triggerKitchen = false;            
         Debug.Log("exit kitchen");
        }

          if (other.gameObject.CompareTag("Disk"))
        {
          triggerDisk=false;
             Debug.Log("exit disk");
        } 

         if (other.gameObject.CompareTag("Baby"))
        {
          triggerBaby=false;
             Debug.Log("exit baby zone");
        } 
        
        
        }

   



}
