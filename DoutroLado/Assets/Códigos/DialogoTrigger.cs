using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour{

  public Dialogo dialogo;

  void OnTriggerStay2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      if(Input.GetKeyDown(KeyCode.X)){
        Movimentação movimentação = outroObjeto.GetComponent<Movimentação>();
        movimentação.podeSeMover = false;

        ComecarDialogo();

      }
    }
  }

  public void ComecarDialogo(){

    FindObjectOfType<ControladorDialogo>().IniciarDialogo(dialogo);

  }

}
