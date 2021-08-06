using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour{

    public float velocidade = 20f;
    public int dano=1;
    public Rigidbody2D corpo;

    // Start is called before the first frame update
    void Start(){

        corpo.velocity = transform.right*velocidade;

    }

    void OnTriggerEnter2D(Collider2D hitInfo){

      if(hitInfo.gameObject.tag.Equals("Inimigo")){
        //Debug.Log(hitInfo.transform.name);
        Inimigo inimigo = hitInfo.GetComponent<Inimigo>();
        if(inimigo != null){
          inimigo.TomaDano(dano);
        }

      }
      /*
      else if(hitInfo.gameObject.tag.Equals("Player")){
        Player player = hitInfo.GetComponent<Player>();
        if(player != null){
          player.TomaDano(dano);
        }
      }
      */

    }

}
