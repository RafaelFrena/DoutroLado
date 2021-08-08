using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDialogo : MonoBehaviour{

    public Text nomeText;
    public Text dialogoText;
    public Animator animator;
    public Queue<string> falas;

    // Start is called before the first frame update
    void Start(){
      falas = new Queue<string>();
    }

    void Update(){

      if(Input.GetKeyDown(KeyCode.X)){

        MostrarProximaFala();

      }

    }

    public void IniciarDialogo(Dialogo dialogo){

      animator.SetBool("estaAberto", true);
      nomeText.text = dialogo.nome;
      falas.Clear();

      foreach(string fala in dialogo.falas){
        falas.Enqueue(fala);
      }

      MostrarProximaFala();

    }

    public void MostrarProximaFala(){
      if(falas.Count == 0){
        TerminarDialogo();
        return;
      }

      string fala = falas.Dequeue();
      StopAllCoroutines();
      StartCoroutine(EscreverFala(fala));
    }

    IEnumerator EscreverFala(string fala){
      dialogoText.text = "";
      foreach (char letra in fala.ToCharArray()){
        dialogoText.text += letra;
        yield return null;
      }

    }

    public void TerminarDialogo(){
      animator.SetBool("estaAberto", false);

      Movimentação movimentação = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimentação>();
      movimentação.podeSeMover = true;
    }

}
