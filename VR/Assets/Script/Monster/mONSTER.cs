using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mONSTER : MonoBehaviour
{

    //Public Variables
    public float speed;
    public Transform player;




    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) > 0.2)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position,speed*Time.deltaTime);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MainCamera")
        {
            speed = 0;
        }
    }

}
