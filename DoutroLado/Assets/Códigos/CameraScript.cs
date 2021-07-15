using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject jogador;
    public float xMaximo;
    public float xMinimo;
    public float yMaximo;
    public float yMinimo;

    // Start is called before the first frame update
    void Start(){
      jogador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate(){
      float x = Mathf.Clamp(jogador.transform.position.x, xMinimo, xMaximo);
      float y = Mathf.Clamp(jogador.transform.position.y, yMinimo, yMaximo);
      gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
    }
}
