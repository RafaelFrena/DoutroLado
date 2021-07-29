using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour{

    public Rigidbody2D corpo;
    public Animator animator;

    //andar
    public int velocidade;
    private float sentido;

    //pular
    public float forcapulo = 6f;
    public float fastfall = 3f;
    //detector do chao
    public Transform detectorChao;
    public LayerMask chao;
    private bool noChao;
    private bool direita = true;

    // Start is called before the first frame update
    void Start(){

      corpo = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update(){

      //ANDAR PARA OS LADOS
      sentido = Input.GetAxis("Horizontal");
      noChao = Physics2D.Linecast(transform.position, detectorChao.position, chao);
      animator.SetBool("noChao", noChao);

      corpo.velocity = new Vector2(sentido*velocidade, corpo.velocity.y);
      animator.SetFloat("Velocidade", Mathf.Abs(sentido)); //animar ariel-anda

      //PULAR
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
      //resolver bug da ariel de um jeito que a bala vá pra esquerda também
      if(sentido > 0){
        return;
      }else if(sentido < 0){
        transform.Rotate(0f, 180f, 0f);
      }

      /*
      Vector2 escala = transform.localScale;
      if((escala.x > 0 && !direita) || (escala.x < 0 && direita)){
        escala.x = escala.x * -1;
        transform.localScale = escala;
      }
      */

    }

}
