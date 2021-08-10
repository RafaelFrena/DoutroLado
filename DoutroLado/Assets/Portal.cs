using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour{

      void OnCollisionEnter2D(Collision2D outroObjeto){

        if(outroObjeto.gameObject.tag.Equals("Player")){

          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

      }

}
