using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour{

  [SerializeField]
  private bool dialogoAuto=false;
  private bool primeiraVez=true;
  public Dialogo dialogo;


  void OnTriggerStay2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      if(Input.GetKeyDown(KeyCode.X) || dialogoAuto == true){

        Movimentação movimentação = outroObjeto.GetComponent<Movimentação>();
        movimentação.podeSeMover = false;
        ComecarDialogo();
        dialogoAuto=false;

      }

    }
  }

  public void ComecarDialogo(){

    FindObjectOfType<ControladorDialogo>().IniciarDialogo(dialogo);

  }

}
