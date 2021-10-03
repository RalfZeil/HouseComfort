using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSwitch : MonoBehaviour
{
    public GameObject darkHouseCam;
    int sChance;
    public int inspects;
    public GameObject houseCam;

    public Think think;
    private string bedText = "You feel tired, you should go to bed.";

    public void darkHouse(float time)
    {
        if (inspects >= 9)
        {
            think.Interact(bedText);
        }
        else 
        {
            if (Random.Range(1, 10) <= sChance)
            {
                sChance = 0;

                Vector3 eulerRotation = new Vector3(houseCam.transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
                darkHouseCam.transform.rotation = Quaternion.Euler(eulerRotation);

                darkHouseCam.SetActive(true);

                StartCoroutine(wait(time));

            }
            else
            {
                sChance += 1;
            }
        }
    }

    IEnumerator wait(float time)
    {
        yield return new WaitForSeconds (time);
        darkHouseCam.SetActive(false);
    }

}
