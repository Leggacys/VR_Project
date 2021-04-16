using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float distance;
    [SerializeField] private LayerMask enemyLayer;

    public void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit,distance,enemyLayer))
        {
            Debug.Log(hit.collider.name);
            Debug.DrawRay(transform.position, transform.forward, Color.black);
        }
    }
}
