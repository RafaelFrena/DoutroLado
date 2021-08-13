using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ControladorVideo : MonoBehaviour{

    public VideoPlayer video;
    public static bool estaPausado = false;
    //public bool videoAcabou=false;

    public double tempo, tempoAtual;

    // Use this for initialization
    void Start(){
      tempo = gameObject.GetComponent<VideoPlayer>().clip.length;
    }

    // Update is called once per frame
    void Update(){

      tempoAtual = gameObject.GetComponent<VideoPlayer>().time;
      if(tempoAtual+.3f >= tempo){
        //videoAcabou=true;
        SceneManager.LoadScene("FaseInicial");
      }

      if(Input.GetKeyDown(KeyCode.Space)){
        if(estaPausado){
          ContinuarVideo();
        }else{
          PausarVideo();
        }
      }



    }

    public void ContinuarVideo(){

      video.Play();
      estaPausado = false;

    }

    void PausarVideo(){

      video.Pause();
      estaPausado = true;

    }

    void TerminaVideo(){
      Debug.Log("INDO PRO JOGO");
      SceneManager.LoadScene("FaseInicial");
    }

}
