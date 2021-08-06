using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInteracao : MonoBehaviour{

    public GameObject lucius;
    // Update is called once per frame
    void Update(){

      void OnTriggerEnter2D(Collider2D hit){

        if(hit.gameObject.tag.Equals("Player")){
          Debug.Log("TRIGGER ATIVADO");
          //IniciarDialogo();
        }

    }

  }

}
