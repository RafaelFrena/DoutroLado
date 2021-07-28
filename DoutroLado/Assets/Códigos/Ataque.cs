using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour{

  public Transform posicaoDoTiro;
  public GameObject projetilPrefab;
  public Animator animator;
  public bool atacando=false;

  void update(){

    if(Input.GetKey(KeyCode.Mouse0)){
      Atira();
      atacando=true;
    }

    if(atacando){
      animator.SetTrigger("Atacando");
    } else{
      animator.ResetTrigger("Atacando");
    }
  }

  void Atira(){

    Instantiate(projetilPrefab, posicaoDoTiro.position, posicaoDoTiro.rotation);

  }

}
