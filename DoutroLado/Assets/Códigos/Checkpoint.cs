using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour{

    private ControladorRespawn controladorRespawn;

    // Start is called before the first frame update
    void Start(){

      controladorRespawn = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<ControladorRespawn>();

    }

    void OnTriggerEnter2D(Collider2D outroObjeto){
      if(outroObjeto.gameObject.tag.Equals("Player")){
        controladorRespawn.ultimoCheckpoint = transform.position;
      }
    }
}
