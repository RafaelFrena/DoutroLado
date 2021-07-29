using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour{

  [SerializeField]
  private int vida = 3;

  public void TomaDano(int dano)
  {

        vida -= dano;
    if(vida <= 0)
    {
    Morre();
    }

  }

  private void Morre()
  {
      Destroy(gameObject);
  }
}
