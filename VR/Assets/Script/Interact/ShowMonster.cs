using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMonster : MonoBehaviour
{
    public Animator anim;
    public Animator canvas;
    
    public void Show()
    {
        anim.SetTrigger("Reset");
    }

    public void Reset()
    {
        canvas.SetTrigger("Reset");
    }
}
