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
    private ControladorRespawn cr;

    // Start is called before the first frame update
    void Start(){

        morto = false;
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
          morto = true;
          animator.SetBool("Morto", true);
          StartCoroutine(morre());
        }

    }

    public void danoMax(){

        vida = 0;
        morto = true;
        animator.SetBool("Morto", true);
        StartCoroutine(morre());

    }

    IEnumerator morre(){

        yield return new WaitForSeconds(1f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        transformAriel = gameObject.GetComponent<Transform>();
        cr = GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<ControladorRespawn>();
        transformAriel.position = cr.ultimoCheckpoint;
        vida=5;
        morto = false;
        animator.SetBool("Morto", false);

    }

}
