using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour{

  public void Jogar(){
    SceneManager.LoadScene("CutsceneInicial");
    Time.timeScale = 1f;
  }

  public void Sair(){
    Debug.Log("SAINDO DO JOGO");
    Application.Quit();
  }

}
