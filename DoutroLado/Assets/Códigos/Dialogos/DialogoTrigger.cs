using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour{

  [SerializeField]
  private bool dialogoAuto=false;
  public Dialogo dialogo;


  void OnTriggerStay2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      if((Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.K) || Input.GetButtonDown("Submit")) || dialogoAuto == true){

        Movimentação movimentação = outroObjeto.GetComponent<Movimentação>();
        movimentação.podeSeMover = false;

        TravaRumpitur();

        ComecarDialogo();
        dialogoAuto=false;

      }

    }
  }

  void OnTriggerExit2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      TravaRumpitur();
    }
  }

  void TravaRumpitur(){

    GameObject rumpitur = GameObject.FindGameObjectWithTag("Inimigo");
    SeguirPlayer seguirPlayer = rumpitur.GetComponent<SeguirPlayer>();


    if(seguirPlayer.rumpiturPodeSeMover == true){
      seguirPlayer.rumpiturPodeSeMover = false;
    }else{
      seguirPlayer.rumpiturPodeSeMover = true;
    }


  }

  public void ComecarDialogo(){

    FindObjectOfType<ControladorDialogo>().IniciarDialogo(dialogo);

  }

}
