using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Think : MonoBehaviour
{

    public GameObject thinkCloud;
    public Text thinkCloudText;

    public GameObject interact;
    public Text interactText;
    public Animator click;

    public GameObject bed;


    public void ObjectRange(string ObjectName, bool Enter)
    {
        interact.SetActive(Enter);
        interactText.text = ObjectName;
    }



    public void Interact(string message)
    {
        thinkCloud.SetActive(true);
        thinkCloudText.text = message;
        click.SetTrigger("Clicked");
        StartCoroutine(wait(4));
        if (message == "You feel tired, you should go to bed.") 
        {
            thinkCloudText.text = message;
            bed.SetActive(true);
        }
        
    }

    IEnumerator wait(int time)
    {
        yield return new WaitForSeconds(time);
        thinkCloud.SetActive(false);
    }


}
