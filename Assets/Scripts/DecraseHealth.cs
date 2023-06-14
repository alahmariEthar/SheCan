using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;

public class DecraseHealth : MonoBehaviour
{
 [SerializeField] AudioManager audioManager;
 public int maxHealth= 100;
      public int currentHealth;
      public GameObject LoseScreen;
      public GameObject babycrying;
     // public SoundManager sm;

  
      public HealthBar healthBar; //UI
    //  [SerializeField] public int damagetaken;
    //--------
      bool triggerDisk = false;
   

    void Start() {
       
       StartCoroutine(Decrease());
         currentHealth= maxHealth;
          healthBar.SetMaxHealth(maxHealth);

    }


      IEnumerator Decrease()   {    
          while(true)   {
            yield return new WaitForSeconds(2f);
          TakeDamage(10);
     //  Update();
       }
        }





    /* IEnumerator Start()
     {    
            while(true) 
          {
             yield return new WaitForSeconds(2f);
           TakeDamage(10);
          //   currentHealth += damagetaken;
           Update();
            }
             currentHealth= maxHealth;
          healthBar.SetMaxHealth(maxHealth);
     }*/

      void Update() {

      if(Input.GetKeyDown(KeyCode.Space)&& triggerDisk&& currentHealth<100){
       IncreaseHealth(10);
      }   

      

      }
    
    //  private void FixedUpdate() {  }


       void TakeDamage(int damage){
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);

           if(currentHealth==60&&currentHealth>0){
              Debug.Log("PLay baby cring");
       audioManager.PlayOneShot("BabyCry");
       babycrying.SetActive(true);

      }if(currentHealth>60){
         Debug.Log("stop baby cring");
        audioManager.Stop("BabyCry");
        babycrying.SetActive(false);
      }

       if(currentHealth==0){
        //LoseScreen.SetActive(true);
        audioManager.Stop("BabyCry");
          SceneManager.LoadScene("Loss");
      }

    }

   
     void OnEnable() {

    
    }

      void IncreaseHealth(int damage){
        currentHealth +=damage;
        healthBar.SetHealth(currentHealth);

    }

       private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Baby"))
        {
             triggerDisk=true;
             Debug.Log("inter Baby Zone");
        } }


         private void OnTriggerExit2D(Collider2D other)
        {
          if (other.gameObject.CompareTag("Baby"))
        {
          triggerDisk=false;
             Debug.Log("exit Baby zone");
        } 

}

}
