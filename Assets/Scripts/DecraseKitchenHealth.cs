using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;


public class DecraseKitchenHealth : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;

      public int maxHealth= 100;
      public int currentHealth;
      public GameObject LoseScreen;
      public GameObject Kitchen2;

      public HealthBar healthBar; 
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
       }
        }


      void Update() {

      if(Input.GetKeyDown(KeyCode.Space)&& triggerDisk&& currentHealth<100){
       IncreaseHealth(10);
      }   

      

      }


       void TakeDamage(int damage){
        currentHealth -=damage;
        healthBar.SetHealth(currentHealth);

           if(currentHealth<60&&currentHealth>0){
              Debug.Log("PLay baby cring");
       audioManager.PlayOneShot("Fire");
       Kitchen2.SetActive(true);

      }if(currentHealth>60){
         Debug.Log("stop baby cring");
        audioManager.Stop("Fire");
       Kitchen2.SetActive(false);
      }

        if(currentHealth==0){
     //  LoseScreen.SetActive(true);
       audioManager.Stop("Fire");
       SceneManager.LoadScene("Loss");
      }

    }


      void IncreaseHealth(int damage){
        currentHealth +=damage;
        healthBar.SetHealth(currentHealth);

    }

       private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Kitchen"))
        {
             triggerDisk=true;
             Debug.Log("inter Kitchen");
        } }


         private void OnTriggerExit2D(Collider2D other)
        {
          if (other.gameObject.CompareTag("Kitchen"))
        {
          triggerDisk=false;
             Debug.Log("exit Kitchen");
        } 

}
}
