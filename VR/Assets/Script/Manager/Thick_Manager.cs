using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Thick_Manager: MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(loadlevel());
    }

    IEnumerator  loadlevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
        yield return null;

    }
}
