using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecraseHealth : MonoBehaviour
{
 
      public int maxHealth= 100;
      public int currentHealth;
  
      public HealthDisk healthBar; //UI
    //  [SerializeField] public int damagetaken;
    //--------
      bool triggerDisk = false;
   

    void Start()
    {
       
    //    StartCoroutine(Decrease());
       //  currentHealth= maxHealth;
         //  healthBar.SetMaxHealth(maxHealth);
    }
   // IEnumerator Decrease()   {    
       //     while(true)   {
          //   yield return new WaitForSeconds(2f);
         //  TakeDamage(10);
           // Update();
      //      }
     //}
  /*IEnumerator Start()
     {    
            while(true) 
          {
             yield return new WaitForSeconds(2f);
           TakeDamage(10);
          //   currentHealth += damagetaken;
             Update();
               currentHealth= maxHealth;
           healthBar.SetMaxHealth(maxHealth);
            }
     }*/

      void Update() {
      if(Input.GetKeyDown(KeyCode.Space)&& triggerDisk){
       IncreaseHealth(10);
      }   
      }

       void TakeDamage(int damage){
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);
    }

      void IncreaseHealth(int damage){
        currentHealth +=damage;
        healthBar.SetHealth(currentHealth);
    }

       private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Disk"))
        {
             triggerDisk=true;
             Debug.Log("inter disk");
        } }


         private void OnTriggerExit2D(Collider2D other)
        {
          if (other.gameObject.CompareTag("Disk"))
        {
          triggerDisk=false;
             Debug.Log("exit disk");
        } 

}

}
