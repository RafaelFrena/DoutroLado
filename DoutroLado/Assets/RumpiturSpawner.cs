using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RumpiturSpawner : MonoBehaviour{

  //public Transform checkpoint;
  public Transform rumpiturLocalSpawn;
  public GameObject rumpiturPrefab;
  //public Animator animator;

  void Start(){
    //animator = gameObject.GetComponent<Animator>();
  }

  void OnTriggerEnter2D(Collider2D outroObjeto){
    if(outroObjeto.gameObject.tag.Equals("Player")){
      
      CriaRumpitur();

    }

  }

  void CriaRumpitur(){
    Instantiate(rumpiturPrefab, rumpiturLocalSpawn.position, rumpiturLocalSpawn.rotation);
  }

}
