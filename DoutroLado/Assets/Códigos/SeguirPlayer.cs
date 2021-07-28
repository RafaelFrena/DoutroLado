/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour
{
  public Transform DetectaChao;
  public float distancia = 3;
  public bool olhandoParaDireita;
  public float velocidade= 4;

  void Start()
  {
     olhandoParaDireita=true;
  }

  void Update()
  {
     Patrulha() ;
  }

  public void Patrulha()
  {
     transform.Translate(Vector2.right * velocidade * Time.deltaTime);

     RaycastHit2D groundInfo = Physics2D.Raycast(DetectaChao.position, Vector2.down, distancia);
     if (groundInfo.collider == false)
     {
         if (olhandoParaDireita == true)
         {
             transform.eulerAngles = new Vector3(0, -180, 0);
             olhandoParaDireita= false;
         }
         else
         {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = true;
         }
     }
  }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour{

  public float velocidade = 2;
  public float distancialimite = 1;
  private Transform alvo;

  void Start(){
    alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
  }

  void Update(){
    if (Vector2.Distance(transform.position, alvo.position) > distancialimite){
      transform.position = Vector2.MoveTowards(transform.position, alvo.position, velocidade*Time.deltaTime);
    }
  }

  void LateUpdate(){
    viraJogador();
  }

  void viraJogador(){
    if(velocidade < 0){
      transform.eulerAngles = new Vector3(0, -180, 0);
    }else if(velocidade > 0){
      transform.eulerAngles = new Vector3(0, 0, 0);
    }
  }

}
