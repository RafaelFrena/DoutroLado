using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour{

  private Transform alvo;
  public Animator animator;

  public float velocidade = 2;
  public float distancialimite = 0.5f;
  public bool rumpiturPodeSeMover=true;

  void Start(){
    alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    rumpiturPodeSeMover=true;
  }

  void Update(){

    if(rumpiturPodeSeMover==true){
      if(Vector2.Distance(transform.position, alvo.position) > distancialimite){
        velocidade=2;
        transform.position = Vector2.MoveTowards(transform.position, alvo.position, velocidade*Time.deltaTime);
      }
    }else{
      velocidade=0f;
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
