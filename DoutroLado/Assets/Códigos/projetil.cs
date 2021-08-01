using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour{

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
        //Destroy(gameObject);
        Inimigo inimigo = hitInfo.GetComponent<Inimigo>();
        if(inimigo != null){
          inimigo.TomaDano(dano);
        }

      }

    }

}
