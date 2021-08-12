using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Saude : MonoBehaviour{

    public Transform localNascimento;
    private Transform transformAriel;

    public int vida = 5;
    public int numCoracoes;

    public Image[] coracoes;
    public Sprite coracao;
    public Sprite coracaovazio;

    public bool morto;
    private Animator animator;

    // Start is called before the first frame update
    void Start(){

        morto = false;
        animator = gameObject.GetComponent<Animator>();

    }

    void Update(){

      atualizaCoracoes();

      void OnTriggerEnter2D(Collider2D outroObjeto){
        Debug.Log("PASSEI POR UM CHECKPOINT!");
        if(outroObjeto.gameObject.tag.Equals("Checkpoint")){
          Debug.Log("E EU SOU A ARIEL!");
          localNascimento.position = outroObjeto.transform.position;
        }
      }

    }

    void atualizaCoracoes(){

      if (vida > numCoracoes){
        vida = numCoracoes;
      }

      for (int i=0; i<coracoes.Length; i++) {

        if(i < vida){
          coracoes[i].sprite = coracao;
        }else{
          coracoes[i].sprite = coracaovazio;
        }

        if(i < numCoracoes){
          coracoes[i].enabled = true;
        }else{
          coracoes[i].enabled = false;
        }
      }

    }

    public void tomaDano(int dano){

        vida -= dano;
        if (vida <= 0){
            morto = true;
            animator.SetTrigger("Morte");

            //if (gameObject.tag == "Player"){
                StartCoroutine(morre());
            //}else{
              //Destroy(gameObject);
            //}
        }

    }

    public void danoMax(){

        vida = 0;
        morto = true;
        animator.SetTrigger("Morte");
        //if (gameObject.tag == "Player"){
            StartCoroutine(morre());
        //}else{
          //Destroy(gameObject);
        //}

    }

    IEnumerator morre(){


        yield return new WaitForSeconds(1f);
        //depois mudar isso pra ir pra telinha de gameover ou algo do tipo
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        transformAriel = gameObject.GetComponent<Transform>();
        transformAriel = localNascimento;

    }

}
