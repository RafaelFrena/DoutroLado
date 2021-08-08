using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour{

  [SerializeField]
  private int vida = 2;

  public void tomaDano(int dano){

    vida -= dano;

    if(vida <= 0){
      Destroy(gameObject);
    }

  }

  void OnTriggerEnter2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){

      //Debug.Log(outroObjeto.transform.name);
      Saude playerSaude = outroObjeto.GetComponent<Saude>();
      if(playerSaude != null){
        Debug.Log("TOMANDO DANO");
        //playerSaude.tomaDano(dano);
      }

    }
  }

}
