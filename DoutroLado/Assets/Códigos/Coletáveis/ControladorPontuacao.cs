using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPontuacao : MonoBehaviour{

    public static ControladorPontuacao instance;
    public Text texto;
    public int espelhosAcumulados;
    public int espelhosNecessarios=20;
    //public int pontuacaoTotal;

    // Start is called before the first frame update
    void Start(){

      if(instance == null){
        instance = this;
      }
      espelhosNecessarios=20;
      //Debug.Log(PlayerPrefs.GetInt("pontuacao"));
      espelhosAcumulados = PlayerPrefs.GetInt("pontuacao");
      texto.text = espelhosAcumulados.ToString();

    }

    public void AtualizaPontuacao(){

      espelhosAcumulados++;
      PlayerPrefs.SetInt("pontuacao", espelhosAcumulados);
      texto.text = espelhosAcumulados.ToString();

      if(espelhosAcumulados >= espelhosNecessarios){
        Debug.Log("TENHO 20 OU MAIS ESPELHOS");

        GameObject outroObjeto = GameObject.FindGameObjectWithTag("PortalDeVolta");
        PortalDeVolta portalDeVolta = outroObjeto.GetComponent<PortalDeVolta>();
        portalDeVolta.ganhouJogo = true;

      }
    }

}
