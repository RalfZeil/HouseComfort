using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;
    private float translation;
    private float straffe;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;	
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape")) {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
