using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour{

    private Transform player;
    public Transform destino;

    // Update is called once per frame
    void Update(){

      Debug.Log("UPDATE");
      void OnCollisionEnter2D(Collision2D outroObjeto){

        Debug.Log("ALGO ENTROU NO PORTAL");

        if(outroObjeto.gameObject.tag.Equals("Player")){

          Debug.Log("PLAYER ENTROU NO PORTAL");
          player = outroObjeto.transform;
          player.position = destino.position;

        }

      }

    }

}
