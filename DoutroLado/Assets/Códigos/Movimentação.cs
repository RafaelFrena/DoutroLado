using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour{

    public Rigidbody2D corpo;
    public int velocidade;
    private float sentido;
    private float direção;
    public float forcapulo;
    public Animator animator;

    // Start is called before the first frame update
    void Start(){

      corpo = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update(){

      //ANDAR PARA OS LADOS
      sentido = Input.GetAxis("Horizontal");
      corpo.velocity = new Vector2(sentido*velocidade, corpo.velocity.y);
      animator.SetFloat("Velocidade", Mathf.Abs(sentido)); //animar ariel-pula
      //PULAR
      if(Input.GetKeyDown(KeyCode.Space)){
        corpo.velocity = Vector2.up*forcapulo;
        animator.SetBool("Pulando", true); //animar ariel-pula
        //(to do: estabeler o "landing" da ariel no tileset)
      }

    }
}
