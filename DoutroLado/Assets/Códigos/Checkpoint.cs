using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour{

    private ControladorRespawn cr;

    // Start is called before the first frame update
    void Start(){

      cr = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<ControladorRespawn>();

    }

    void OnTriggerEnter2D(Collider2D outroObjeto){
      if(outroObjeto.gameObject.tag.Equals("Player")){
        cr.ultimoCheckpoint = transform.position;
      }
    }
}
