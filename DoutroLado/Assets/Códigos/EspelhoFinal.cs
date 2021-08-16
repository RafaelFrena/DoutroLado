using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EspelhoFinal : MonoBehaviour{

  [SerializeField]
  private bool dialogoAuto=false;
  public Dialogo dialogo;
  public bool jogoZerado=false;

  void OnTriggerEnter2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      if(Input.GetKeyDown(KeyCode.X) || dialogoAuto == true){

        Movimentação movimentação = outroObjeto.GetComponent<Movimentação>();
        movimentação.podeSeMover = false;

        if(SceneManager.GetActiveScene().buildIndex == 2){
          ComecarDialogo();
        }else if(SceneManager.GetActiveScene().buildIndex == 4){
          SceneManager.LoadScene("CutsceneFinal");
        }
        /*
        if(jogoZerado==true){
          //Fazer série de eventinhos bacanas pra finalizar o jogo
          Debug.Log("GANHEI O JOGO!");
        }else if(jogoZerado==false){
          ComecarDialogo();
        }*/

      }
    }
  }

  public void ComecarDialogo(){

    FindObjectOfType<ControladorDialogo>().IniciarDialogo(dialogo);

  }

}
