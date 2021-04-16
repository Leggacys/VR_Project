using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManagaer : MonoBehaviour
{
    public Text contdown;

    // Start is called before the first frame update
    void Start()
    {

    }

    public float timeRemaining = 100;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            contdown.text = timeRemaining.ToString();
        }else
        {
            SceneManager.LoadScene(2);
        }
    }
}
