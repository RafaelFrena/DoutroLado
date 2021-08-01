using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour{

  [SerializeField]
  private int vida = 2;

  public void TomaDano(int dano){

    vida -= dano;

    if(vida <= 0){
      Destroy(gameObject);
    }

  }

}
