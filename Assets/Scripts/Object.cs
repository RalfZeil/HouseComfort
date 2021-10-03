using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Object : MonoBehaviour
{
    public Think think;
    public string message;
    public string objectName;

    public Animator anim;

    public DarkSwitch darkSwitch;
    private bool triggered = false;


    void OnTriggerStay(Collider other)
    {
        think.ObjectRange(objectName, true);

        if (Input.GetKeyDown(KeyCode.E) && other.tag == "Player")
        {
            if (objectName == "Bed")
            {
                StartCoroutine(change(0));
            }

            else if (objectName == "The escape")
            {
                StartCoroutine(change(1));
            }
            else
            {
                think.Interact(message);

                if(darkSwitch != null)
                {
                    darkSwitch.darkHouse(0.5f);
                }

                if (!triggered)
                {
                    triggered = true;

                    if (darkSwitch != null)
                    {
                        darkSwitch.inspects += 1;
                    }
                }
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        think.ObjectRange(objectName, false);
    }

    IEnumerator change(int quit) 
    {
        anim.SetBool("Fade", true);
        yield return new WaitForSeconds(1);
        if (quit == 1) 
        {
            Application.Quit();
        }
        else SceneManager.LoadScene(2);
    }
}
