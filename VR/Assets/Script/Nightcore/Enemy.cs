using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform player;
    public float speed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.position)>0.4f)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position,speed*Time.deltaTime);
        }else
        {

        }
    }

    private void Attack()
    {

    }

}
