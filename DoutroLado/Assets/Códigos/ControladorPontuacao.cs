using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPontuacao : MonoBehaviour{

    public static ControladorPontuacao instance;
    public Text texto;
    public int espelhosAcumulados;
    public int espelhosNecessarios=20;

    // Start is called before the first frame update
    void Start(){

      if(instance == null){
        instance = this;
      }

    }

    public void AtualizaPontuacao(int valorObjeto){
      espelhosAcumulados += valorObjeto;
      texto.text = espelhosAcumulados.ToString();
      if(espelhosAcumulados >= espelhosNecessarios){

        GameObject outroObjeto = GameObject.FindGameObjectWithTag("EspelhoFinal");
        EspelhoFinal espelhoFinal = outroObjeto.GetComponent<EspelhoFinal>();
        espelhoFinal.jogoZerado = true;

      }
    }

}
