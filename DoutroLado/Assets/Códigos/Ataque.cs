using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour{

  public Transform posicaoDoTiro;
  public GameObject projetilPrefab;

  void update(){

    if(Input.GetButtonDown("Fire1")){
      //Atira();
      Instantiate(projetilPrefab, posicaoDoTiro.position, posicaoDoTiro.rotation);
    }

  }

  /*
  void Atira(){

    Instantiate(projetil, posicaoDoTiro.position, posicaoDoTiro.rotation);

  }
  */

}
