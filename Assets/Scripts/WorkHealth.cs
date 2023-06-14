using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class WorkHealth : MonoBehaviour
{
   
    public int minHealthDesk= 0;
    public int currentHealth;
   public HealthBar healthBar; 
   bool triggerDisk = false;


     void Start() {

       StartCoroutine(Decrease());
       currentHealth= minHealthDesk;
        healthBar.SetMinHealth(minHealthDesk);
         //currentHealth= maxHealth;
          //healthBar.SetMaxHealth(maxHealth);

    }

      IEnumerator Decrease()   {    
          while(true)   {
            yield return new WaitForSeconds(2f);
            if(currentHealth>0){
             TakeDamage(10);
            }
       
       }
        }

    /* void Start(){
        currentHealth= minHealthDesk;
        healthBar.SetMinHealth(minHealthDesk);
     }*/

     
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)&& triggerDisk&& currentHealth<100){
        IncreaseHealth(20);
         }


    }

 
    void IncreaseHealth(int damage){
        currentHealth +=damage;
       healthBar.SetHealth(currentHealth);
    }

     void TakeDamage(int damage){
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);
      
       if(currentHealth==0){
       SceneManager.LoadScene("Loss");
      }


    }



    
     private void OnTriggerEnter2D(Collider2D other){  

        if (other.gameObject.CompareTag("Disk"))  {
             triggerDisk=true;
             Debug.Log("inter desk");
        }  
        }
     //-----------------------------------------------------
         private void OnTriggerExit2D(Collider2D other)
        {    
          if (other.gameObject.CompareTag("Disk")){
             triggerDisk=false;
             Debug.Log("exit desk");
        }           
        }
}
