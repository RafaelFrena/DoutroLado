using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalDeVolta : MonoBehaviour{

      [SerializeField]
      private bool dialogoAuto=false;
      public Dialogo dialogo;
      public bool ganhouJogo=false;

      void OnTriggerEnter2D(Collider2D outroObjeto){
        if(outroObjeto.gameObject.tag.Equals("Player")){

          if(ganhouJogo==true){
            SceneManager.LoadScene("FaseFinal");
          }

          }

        }

        public void ComecarDialogo(){

          FindObjectOfType<ControladorDialogo>().IniciarDialogo(dialogo);

        }
}
