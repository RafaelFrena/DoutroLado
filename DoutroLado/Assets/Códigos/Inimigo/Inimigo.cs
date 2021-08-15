using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour{

  [SerializeField]
  private int vida = 3;
  public Animator animator;

  void Start(){
    animator = gameObject.GetComponent<Animator>();
  }

  public void tomaDano(int dano){

    vida -= dano;

    if(vida <= 0){
      animator.SetTrigger("Morte");
      Destroy(gameObject);
      //StartCoroutine(morre());
    }

  }

  void OnTriggerEnter2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){

      //Debug.Log(outroObjeto.transform.name);
      Saude playerSaude = outroObjeto.GetComponent<Saude>();
      if(playerSaude != null){
        playerSaude.tomaDano(1);
        Destroy(gameObject);
      }

    }
  }

  /*IEnumerator morre(){

      yield return new WaitForSeconds(1f);
      Destroy(gameObject);

  }*/

}
