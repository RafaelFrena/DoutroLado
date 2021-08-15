using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour{

      void OnTriggerEnter2D(Collider2D outroObjeto){

        if(outroObjeto.gameObject.tag.Equals("Player")){

          if(SceneManager.GetActiveScene().buildIndex == 2){
            SceneManager.LoadScene("Caverna");
          }else if(SceneManager.GetActiveScene().buildIndex == 3){
            SceneManager.LoadScene("FaseInicial");
          }


        }

      }

}
