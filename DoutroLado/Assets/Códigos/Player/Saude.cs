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

    //public bool morto;
    private Animator animator;
    private ControladorRespawn controladorRespawn;

    // Start is called before the first frame update
    void Start(){

        //morto = false;
        animator = gameObject.GetComponent<Animator>();

    }

    void Update(){

      atualizaCoracoes();

    }

    void atualizaCoracoes(){

      if (vida > numCoracoes){
        vida = numCoracoes;
      }

      for (int i=0; i<coracoes.Length; i++){

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
          //morto = true;
          animator.SetBool("Morto", true);
          StartCoroutine(morre());
        }

    }

    public void danoMax(){

        vida = 0;
        //morto = true;
        animator.SetBool("Morto", true);
        StartCoroutine(morre());

    }

    IEnumerator morre(){

        //BLOQUEIA MOVIMENTAÇÃO
        Movimentação movimentação = gameObject.GetComponent<Movimentação>();
        movimentação.podeSeMover = false;
        //ESPERA UM DETERMINADO TEMPO
        yield return new WaitForSeconds(1.5f);
        //VOLTA PRO CHECKPOINT
        transformAriel = gameObject.GetComponent<Transform>();
        controladorRespawn = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<ControladorRespawn>();
        transformAriel.position = controladorRespawn.ultimoCheckpoint;
        //RESETA A VIDA
        vida=5;
        //DESLIGA ANIMAÇÕES E DEMAIS BOOLEANS
        //morto = false;
        animator.SetBool("Morto", false);
        //LIBERA MOVIMENTAÇÃO
        movimentação.podeSeMover = true;
    }

}
