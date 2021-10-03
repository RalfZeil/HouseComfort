using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour
{

    public GameObject player;
    public float speed = 0.003f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsPlayer();
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
    }
}
