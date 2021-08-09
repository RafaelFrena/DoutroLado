using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMorte : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D outroObjeto)
    {
        if (outroObjeto.gameObject.tag.Equals("Player"))
        {
            outroObjeto.gameObject.GetComponent<Saude>().danoMax();
        }
        else
        {
            Object.Destroy(outroObjeto.gameObject);
        }
    }

}
