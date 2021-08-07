using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour{

  public int valorMoeda = 1;
  void OnTriggerEnter2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.CompareTag("Player")){
      ControladorPontuacao.instance.AtualizaPontuacao(valorMoeda);
      Destroy(gameObject);
    }
  }

}
