using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour{

  public static bool estaPausado = false;
  public GameObject menuUI;

  // Update is called once per frame
  void Update(){

    if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)){
      if(estaPausado){
        Continuar();
      }else{
        Pausar();
      }
    }

  }

  public void Continuar(){

    menuUI.SetActive(false);
    Time.timeScale = 1f;
    estaPausado = false;

  }

  void Pausar(){

    menuUI.SetActive(true);
    Time.timeScale = 0f;
    estaPausado = true;

  }

  public void Sair(){
    SceneManager.LoadScene("MenuInicial");
  }

}
