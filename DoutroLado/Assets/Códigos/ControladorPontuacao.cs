using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPontuacao : MonoBehaviour{

    public static ControladorPontuacao instance;
    public Text texto;
    int pontuacao;
    // Start is called before the first frame update
    void Start(){

      if(instance == null){
        instance = this;
      }

    }

    public void AtualizaPontuacao(int valorMoeda){
      pontuacao += valorMoeda;
      texto.text = pontuacao.ToString();
    }

}
