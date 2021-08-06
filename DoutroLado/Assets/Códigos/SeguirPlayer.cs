using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour{

  private Transform alvo;
  public Animator animator;

  public float velocidade = 2;
  public float distancialimite = 1;
  public bool andando;

  void Start(){
    alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
  }

  void Update(){

    if(Vector2.Distance(transform.position, alvo.position) > distancialimite){
      transform.position = Vector2.MoveTowards(transform.position, alvo.position, velocidade*Time.deltaTime);
      animator.SetBool("Andando", true);
    }


    virarSprite();

  }

  void virarSprite(){
      if(transform.position.x < alvo.transform.position.x){
        Vector2 escala = transform.localScale;
        escala.x = -.7f;
        transform.localScale = escala;
      }else {
        Vector2 escala = transform.localScale;
        escala.x = .7f;
        transform.localScale = escala;
      }
  }

}
