using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour{

  public Transform posicaoDoTiro;
  //public GameObject ariel;
  public GameObject projetilPrefab;
  public Animator animator;
  public bool atacando=false;
  public int dano;

  void Start(){
    animator = gameObject.GetComponent<Animator>();
  }

  void Update(){

    if(Input.GetButtonDown("Fire1")){
      Atira();
      atacando=true;
    }

    if(atacando){
      animator.SetTrigger("Atacando");
      atacando = false;
    }
  }


  void Atira(){
    Instantiate(projetilPrefab, posicaoDoTiro.position, posicaoDoTiro.rotation);
  }

}
