using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Animator anim;


    public void StartButton() 
    {
        StartCoroutine(change(0));
    }

    public void QuitButton() 
    {
        StartCoroutine(change(1));
    }

    IEnumerator change(int quit) 
    {
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1);
        if (quit == 1)
        {
            Application.Quit();
        }
        else SceneManager.LoadScene(1);
    }
}
