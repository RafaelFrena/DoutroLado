using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueInimigo : MonoBehaviour {

 private Transform player;
 public float distancia = 50.0f;
 private bool alcancavel = false;
 public Rigidbody projetilPrefab;

 void Start(){

   player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
   InvokeRepeating("Atira", 2, 2);

 }

 void Update(){

   alcancavel = Vector2.Distance(transform.position, player.position) < distancia;
   if(alcancavel){
     Atira();
   }

 }

 void Atira(){
   //if(alcancavel){
     Instantiate(projetilPrefab, transform.position, transform.rotation);
   //}
 }

}
