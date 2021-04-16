using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Door : MonoBehaviour
{

    //Public Variables
    public GameObject monster;

    //Private Variables
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Open()
    {
        anim.SetTrigger("Open");
        monster.SetActive(true);
    }

    
}
