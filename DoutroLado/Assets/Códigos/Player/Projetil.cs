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
        StartCoroutine(destroy());
    }

    void OnTriggerEnter2D(Collider2D outroObjeto){

      if(outroObjeto.gameObject.tag.Equals("Inimigo")){
        //Debug.Log(hitInfo.transform.name);
        Inimigo inimigo = outroObjeto.GetComponent<Inimigo>();
        if(inimigo != null){
          inimigo.tomaDano(dano);
          Destroy(gameObject);
        }

      }

    }

    IEnumerator destroy(){

        yield return new WaitForSeconds(2f);
        Destroy(gameObject);

    }

}
