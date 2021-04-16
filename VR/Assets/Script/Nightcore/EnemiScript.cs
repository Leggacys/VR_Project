using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            MoveScript.instance.TakeDamage();
        }
        else
            Destroy(gameObject);
    }

}
