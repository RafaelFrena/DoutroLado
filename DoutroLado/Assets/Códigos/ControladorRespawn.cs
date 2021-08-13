using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRespawn : MonoBehaviour{

    private static ControladorRespawn instance;
    public Vector2 ultimoCheckpoint;

    void Awake(){

      if(instance == null){
        instance = this;
        DontDestroyOnLoad(instance);
      }else{
        Destroy(gameObject);
      }
      
    }

}
