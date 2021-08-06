using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour{

  public Dialogo dialogo;

  void OnTriggerStay2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      //congelar movimentação do player
      if(Input.GetKeyDown(KeyCode.X)){
        ComecarDialogo();
      }
      //quando dialogo terminar, devolver movimentação
    }
  }

  public void ComecarDialogo(){

    FindObjectOfType<ControladorDialogo>().IniciarDialogo(dialogo);

  }

}
