using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour{

    public Rigidbody2D corpo;
    public Animator animator;

    public int velocidade;
    public float forcapulo = 6f, fastfall = 3f;
    private float sentido;

    public Transform detectorChao;
    public LayerMask chao;

    private bool noChao, olhandoDireita;
    public bool podeSeMover;

    // Start is called before the first frame update
    void Start(){

      corpo = GetComponent<Rigidbody2D>();
      olhandoDireita = true;
      podeSeMover = true;

    }

    // Update is called once per frame
    void Update(){

      if(podeSeMover==true){

        Anda();
        Pula();

      }else{

        corpo.velocity = new Vector2(0, corpo.velocity.y);
        animator.SetFloat("Velocidade", 0f);
        animator.SetBool("Pulando", false);
        animator.SetBool("noChao", true);

      }

    }

    private void Anda(){

      //MOVIMENTAÇÃO HORIZONTAL
      sentido = Input.GetAxis("Horizontal");
      noChao = Physics2D.Linecast(transform.position, detectorChao.position, chao);
      animator.SetBool("noChao", noChao);

      corpo.velocity = new Vector2(sentido*velocidade, corpo.velocity.y);
      animator.SetFloat("Velocidade", Mathf.Abs(sentido)); //animar ariel-anda

    }

    private void Pula(){

      //MOVIMENTAÇÃO VERTICAL
      if(Input.GetButtonDown("Jump") && noChao){
        corpo.velocity = Vector2.up*forcapulo;
        animator.SetBool("Pulando", true); //animar ariel-pula
      } else if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) && noChao==false){
        corpo.velocity = Vector2.down*fastfall;
        animator.SetBool("Pulando", false); //fastfall
      }

      if(noChao && animator.GetBool("Pulando")){
        animator.SetBool("Pulando", false);
      }

    }

    private void LateUpdate(){

      if(sentido > 0 && !olhandoDireita){
        olhandoDireita = !olhandoDireita;
        transform.Rotate(0f, 180f, 0f);
      }else if(sentido < 0 && olhandoDireita){
        olhandoDireita = !olhandoDireita;
        transform.Rotate(0f, 180f, 0f);
      }

    }

}
