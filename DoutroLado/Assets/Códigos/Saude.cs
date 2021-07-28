using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saude : MonoBehaviour
{
    public bool morto;
    public int saude;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        morto = false;
        animator = gameObject.GetComponent<Animator>();
    }

    public void dano(int x)
    {
        saude -= x;
        if (saude <= 0)
        {
            morto = true;
            animator.SetTrigger("Morte");
            if (gameObject.tag == "Player")
            {
                StartCoroutine(morre());
            }
        }
    }

    public void danoMax()
    {
        saude = 0;
        morto = true;
        animator.SetTrigger("Morte");
        if (gameObject.tag == "Player")
        {
            StartCoroutine(morre());
        }

    }
    IEnumerator morre()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
