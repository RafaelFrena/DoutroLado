using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour{

    public Rigidbody2D corpo;
    public Animator animator;

    //andar
    public int velocidade;
    private float sentido;
    private float direção;
    
    //pular
    public float forcapulo;

    //detector do chao
    public Transform detectorChao;
    public LayerMask chao;
    private bool noChao;

    // Start is called before the first frame update
    void Start(){

      corpo = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update(){

      //ANDAR PARA OS LADOS
      sentido = Input.GetAxis("Horizontal");
      noChao = Physics2D.Linecast(transform.position, detectorChao.position, chao);
      corpo.velocity = new Vector2(sentido*velocidade, corpo.velocity.y);
      animator.SetFloat("Velocidade", Mathf.Abs(sentido)); //animar ariel-anda
      
      //PULAR
      if(Input.GetKeyDown(KeyCode.Space) && noChao){
        corpo.velocity = Vector2.up*forcapulo;
        animator.SetBool("Pulando", true); //animar ariel-pula
      }

    }
}
